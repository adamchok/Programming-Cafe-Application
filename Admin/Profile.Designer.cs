namespace APU_Programming_Cafe.Admin
{
    partial class AdminProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpboxDetails = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAdminID = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.grpboxGeneral = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.grpboxDetails.SuspendLayout();
            this.grpboxGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(460, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROFILE";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(746, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 55);
            this.btnRefresh.TabIndex = 73;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSave.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSave.Location = new System.Drawing.Point(566, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 55);
            this.btnSave.TabIndex = 72;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClose.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClose.Location = new System.Drawing.Point(901, 332);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 55);
            this.btnClose.TabIndex = 71;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnEdit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnEdit.Location = new System.Drawing.Point(901, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 55);
            this.btnEdit.TabIndex = 70;
            this.btnEdit.Text = "Edit Profile";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grpboxDetails
            // 
            this.grpboxDetails.Controls.Add(this.txtPassword);
            this.grpboxDetails.Controls.Add(this.txtAdminID);
            this.grpboxDetails.Controls.Add(this.lblPassword);
            this.grpboxDetails.Controls.Add(this.lblAdminID);
            this.grpboxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxDetails.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpboxDetails.Location = new System.Drawing.Point(566, 83);
            this.grpboxDetails.Name = "grpboxDetails";
            this.grpboxDetails.Size = new System.Drawing.Size(494, 161);
            this.grpboxDetails.TabIndex = 69;
            this.grpboxDetails.TabStop = false;
            this.grpboxDetails.Text = "Security:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPassword.Location = new System.Drawing.Point(180, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(274, 30);
            this.txtPassword.TabIndex = 54;
            // 
            // txtAdminID
            // 
            this.txtAdminID.Enabled = false;
            this.txtAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtAdminID.Location = new System.Drawing.Point(180, 53);
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.Size = new System.Drawing.Size(274, 30);
            this.txtAdminID.TabIndex = 53;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(60, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 26);
            this.lblPassword.TabIndex = 47;
            this.lblPassword.Text = "Password:";
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAdminID.ForeColor = System.Drawing.Color.White;
            this.lblAdminID.Location = new System.Drawing.Point(65, 56);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(109, 26);
            this.lblAdminID.TabIndex = 46;
            this.lblAdminID.Text = "Admin ID:";
            // 
            // grpboxGeneral
            // 
            this.grpboxGeneral.Controls.Add(this.lblAddress);
            this.grpboxGeneral.Controls.Add(this.lblEmail);
            this.grpboxGeneral.Controls.Add(this.lblContactNumber);
            this.grpboxGeneral.Controls.Add(this.txtAddress);
            this.grpboxGeneral.Controls.Add(this.txtEmail);
            this.grpboxGeneral.Controls.Add(this.txtContactNumber);
            this.grpboxGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxGeneral.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpboxGeneral.Location = new System.Drawing.Point(19, 83);
            this.grpboxGeneral.Name = "grpboxGeneral";
            this.grpboxGeneral.Size = new System.Drawing.Size(529, 304);
            this.grpboxGeneral.TabIndex = 68;
            this.grpboxGeneral.TabStop = false;
            this.grpboxGeneral.Text = "General:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(90, 134);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(98, 26);
            this.lblAddress.TabIndex = 56;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(28, 91);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(160, 26);
            this.lblEmail.TabIndex = 55;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblContactNumber.ForeColor = System.Drawing.Color.White;
            this.lblContactNumber.Location = new System.Drawing.Point(11, 47);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(177, 26);
            this.lblContactNumber.TabIndex = 55;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtAddress.Location = new System.Drawing.Point(194, 132);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(318, 154);
            this.txtAddress.TabIndex = 52;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtEmail.Location = new System.Drawing.Point(194, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 30);
            this.txtEmail.TabIndex = 51;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Enabled = false;
            this.txtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtContactNumber.Location = new System.Drawing.Point(194, 44);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(318, 30);
            this.txtContactNumber.TabIndex = 50;
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grpboxDetails);
            this.Controls.Add(this.grpboxGeneral);
            this.Controls.Add(this.label1);
            this.Name = "AdminProfile";
            this.Size = new System.Drawing.Size(1078, 412);
            this.Load += new System.EventHandler(this.AdminProfile_Load);
            this.grpboxDetails.ResumeLayout(false);
            this.grpboxDetails.PerformLayout();
            this.grpboxGeneral.ResumeLayout(false);
            this.grpboxGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpboxDetails;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAdminID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.GroupBox grpboxGeneral;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNumber;
    }
}
