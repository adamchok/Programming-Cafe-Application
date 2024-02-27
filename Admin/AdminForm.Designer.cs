namespace APU_Programming_Cafe.Admin
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnValidatePayment = new System.Windows.Forms.Button();
            this.btnIncomeReport = new System.Windows.Forms.Button();
            this.btnAssignTrainer = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.picMascot = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.picProfileIcon = new System.Windows.Forms.PictureBox();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnRegisterTrainer = new System.Windows.Forms.Button();
            this.btnDeleteTrainer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMascot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.lblAppTitle.Font = new System.Drawing.Font("Consolas", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAppTitle.Location = new System.Drawing.Point(0, 119);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(180, 96);
            this.lblAppTitle.TabIndex = 24;
            this.lblAppTitle.Text = "APU Programming Café";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnFeedback.Location = new System.Drawing.Point(0, 621);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(180, 60);
            this.btnFeedback.TabIndex = 19;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnValidatePayment
            // 
            this.btnValidatePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnValidatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidatePayment.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnValidatePayment.Location = new System.Drawing.Point(0, 555);
            this.btnValidatePayment.Name = "btnValidatePayment";
            this.btnValidatePayment.Size = new System.Drawing.Size(180, 60);
            this.btnValidatePayment.TabIndex = 17;
            this.btnValidatePayment.Text = "Validate Payment";
            this.btnValidatePayment.UseVisualStyleBackColor = false;
            this.btnValidatePayment.Click += new System.EventHandler(this.btnValidatePayment_Click);
            // 
            // btnIncomeReport
            // 
            this.btnIncomeReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnIncomeReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncomeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncomeReport.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnIncomeReport.Location = new System.Drawing.Point(0, 489);
            this.btnIncomeReport.Name = "btnIncomeReport";
            this.btnIncomeReport.Size = new System.Drawing.Size(180, 60);
            this.btnIncomeReport.TabIndex = 15;
            this.btnIncomeReport.Text = "Income Report";
            this.btnIncomeReport.UseVisualStyleBackColor = false;
            this.btnIncomeReport.Click += new System.EventHandler(this.btnIncomeReport_Click);
            // 
            // btnAssignTrainer
            // 
            this.btnAssignTrainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnAssignTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignTrainer.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnAssignTrainer.Location = new System.Drawing.Point(0, 357);
            this.btnAssignTrainer.Name = "btnAssignTrainer";
            this.btnAssignTrainer.Size = new System.Drawing.Size(180, 60);
            this.btnAssignTrainer.TabIndex = 13;
            this.btnAssignTrainer.Text = "Assign Trainer";
            this.btnAssignTrainer.UseVisualStyleBackColor = false;
            this.btnAssignTrainer.Click += new System.EventHandler(this.btnAssignTrainer_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnHome.Location = new System.Drawing.Point(0, 225);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(180, 60);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // picMascot
            // 
            this.picMascot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.picMascot.Image = ((System.Drawing.Image)(resources.GetObject("picMascot.Image")));
            this.picMascot.Location = new System.Drawing.Point(44, 12);
            this.picMascot.Name = "picMascot";
            this.picMascot.Size = new System.Drawing.Size(91, 104);
            this.picMascot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMascot.TabIndex = 23;
            this.picMascot.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(180, 681);
            this.splitter1.TabIndex = 22;
            this.splitter1.TabStop = false;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewProfile.Location = new System.Drawing.Point(365, 297);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(712, 54);
            this.btnViewProfile.TabIndex = 21;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = false;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // picProfileIcon
            // 
            this.picProfileIcon.Image = ((System.Drawing.Image)(resources.GetObject("picProfileIcon.Image")));
            this.picProfileIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("picProfileIcon.InitialImage")));
            this.picProfileIcon.Location = new System.Drawing.Point(386, 119);
            this.picProfileIcon.Name = "picProfileIcon";
            this.picProfileIcon.Size = new System.Drawing.Size(138, 134);
            this.picProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfileIcon.TabIndex = 20;
            this.picProfileIcon.TabStop = false;
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdminID.Location = new System.Drawing.Point(560, 199);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(299, 32);
            this.lblAdminID.TabIndex = 18;
            this.lblAdminID.Text = "- Insert Admin ID -";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdminName.Location = new System.Drawing.Point(558, 142);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(482, 47);
            this.lblAdminName.TabIndex = 16;
            this.lblAdminName.Text = "- Insert Admin Name -";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblAdmin.Location = new System.Drawing.Point(196, 12);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(130, 47);
            this.lblAdmin.TabIndex = 14;
            this.lblAdmin.Text = "ADMIN";
            // 
            // btnRegisterTrainer
            // 
            this.btnRegisterTrainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnRegisterTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterTrainer.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRegisterTrainer.Location = new System.Drawing.Point(0, 291);
            this.btnRegisterTrainer.Name = "btnRegisterTrainer";
            this.btnRegisterTrainer.Size = new System.Drawing.Size(180, 60);
            this.btnRegisterTrainer.TabIndex = 25;
            this.btnRegisterTrainer.Text = "Register Trainer";
            this.btnRegisterTrainer.UseVisualStyleBackColor = false;
            this.btnRegisterTrainer.Click += new System.EventHandler(this.btnRegisterTrainer_Click);
            // 
            // btnDeleteTrainer
            // 
            this.btnDeleteTrainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnDeleteTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTrainer.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnDeleteTrainer.Location = new System.Drawing.Point(0, 423);
            this.btnDeleteTrainer.Name = "btnDeleteTrainer";
            this.btnDeleteTrainer.Size = new System.Drawing.Size(180, 60);
            this.btnDeleteTrainer.TabIndex = 26;
            this.btnDeleteTrainer.Text = "Delete Trainer";
            this.btnDeleteTrainer.UseVisualStyleBackColor = false;
            this.btnDeleteTrainer.Click += new System.EventHandler(this.btnDeleteTrainer_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnDeleteTrainer);
            this.Controls.Add(this.btnRegisterTrainer);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnValidatePayment);
            this.Controls.Add(this.btnIncomeReport);
            this.Controls.Add(this.btnAssignTrainer);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.picMascot);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.picProfileIcon);
            this.Controls.Add(this.lblAdminID);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.lblAdmin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMascot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnValidatePayment;
        private System.Windows.Forms.Button btnIncomeReport;
        private System.Windows.Forms.Button btnAssignTrainer;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox picMascot;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.PictureBox picProfileIcon;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnRegisterTrainer;
        private System.Windows.Forms.Button btnDeleteTrainer;
    }
}