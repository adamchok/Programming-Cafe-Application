namespace APU_Programming_Cafe.Lecturer
{
    partial class LecturerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerForm));
            this.panelFunctionBar = new System.Windows.Forms.Panel();
            this.picMascot = new System.Windows.Forms.PictureBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnHomeScreen = new System.Windows.Forms.Button();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblLecturerName = new System.Windows.Forms.Label();
            this.lblLecturerID = new System.Windows.Forms.Label();
            this.picProfileIcon = new System.Windows.Forms.PictureBox();
            this.removeStudent = new APU_Programming_Cafe.Lecturer.RemoveStudent();
            this.enrolment_Request = new APU_Programming_Cafe.Lecturer.Enrolment_Request();
            this.update_Enrolment = new APU_Programming_Cafe.Lecturer.Update_Enrolment();
            this.register_and_Ennrol = new APU_Programming_Cafe.Login.Register_and_Ennrol();
            this.lecturer_Profile1 = new APU_Programming_Cafe.Lecturer.Lecturer_Profile();
            this.panelFunctionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFunctionBar
            // 
            this.panelFunctionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.panelFunctionBar.Controls.Add(this.picMascot);
            this.panelFunctionBar.Controls.Add(this.btnRequest);
            this.panelFunctionBar.Controls.Add(this.btnRemove);
            this.panelFunctionBar.Controls.Add(this.btnUpdate);
            this.panelFunctionBar.Controls.Add(this.btnRegister);
            this.panelFunctionBar.Controls.Add(this.btnHomeScreen);
            this.panelFunctionBar.Controls.Add(this.lblAppTitle);
            this.panelFunctionBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFunctionBar.Location = new System.Drawing.Point(0, 0);
            this.panelFunctionBar.Name = "panelFunctionBar";
            this.panelFunctionBar.Size = new System.Drawing.Size(180, 681);
            this.panelFunctionBar.TabIndex = 0;
            // 
            // picMascot
            // 
            this.picMascot.Image = ((System.Drawing.Image)(resources.GetObject("picMascot.Image")));
            this.picMascot.Location = new System.Drawing.Point(12, 9);
            this.picMascot.Name = "picMascot";
            this.picMascot.Size = new System.Drawing.Size(155, 115);
            this.picMascot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMascot.TabIndex = 11;
            this.picMascot.TabStop = false;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRequest.Location = new System.Drawing.Point(0, 493);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(180, 61);
            this.btnRequest.TabIndex = 6;
            this.btnRequest.Text = "Enrolment Request";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRemove.Location = new System.Drawing.Point(0, 576);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(180, 61);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove Student";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnUpdate.Location = new System.Drawing.Point(0, 410);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 61);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Enrolment";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRegister.Location = new System.Drawing.Point(0, 327);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(180, 61);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register and Enrol";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnHomeScreen
            // 
            this.btnHomeScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnHomeScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeScreen.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnHomeScreen.Location = new System.Drawing.Point(0, 244);
            this.btnHomeScreen.Name = "btnHomeScreen";
            this.btnHomeScreen.Size = new System.Drawing.Size(180, 61);
            this.btnHomeScreen.TabIndex = 1;
            this.btnHomeScreen.Text = "Home";
            this.btnHomeScreen.UseVisualStyleBackColor = false;
            this.btnHomeScreen.Click += new System.EventHandler(this.btnHomeScreen_Click);
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(12, 137);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(155, 84);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "APU\r\nProgramming\r\nCafe\r\n";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "LECTURER\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnProfile.Location = new System.Drawing.Point(360, 295);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(679, 48);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "View Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblLecturerName
            // 
            this.lblLecturerName.AutoSize = true;
            this.lblLecturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturerName.ForeColor = System.Drawing.Color.White;
            this.lblLecturerName.Location = new System.Drawing.Point(563, 145);
            this.lblLecturerName.Name = "lblLecturerName";
            this.lblLecturerName.Size = new System.Drawing.Size(476, 46);
            this.lblLecturerName.TabIndex = 8;
            this.lblLecturerName.Text = "- Insert Lecturer Name - ";
            this.lblLecturerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLecturerID
            // 
            this.lblLecturerID.AutoSize = true;
            this.lblLecturerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblLecturerID.ForeColor = System.Drawing.Color.White;
            this.lblLecturerID.Location = new System.Drawing.Point(565, 202);
            this.lblLecturerID.Name = "lblLecturerID";
            this.lblLecturerID.Size = new System.Drawing.Size(271, 31);
            this.lblLecturerID.TabIndex = 9;
            this.lblLecturerID.Text = "- Insert LecturerID -";
            this.lblLecturerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picProfileIcon
            // 
            this.picProfileIcon.Image = ((System.Drawing.Image)(resources.GetObject("picProfileIcon.Image")));
            this.picProfileIcon.Location = new System.Drawing.Point(395, 127);
            this.picProfileIcon.Name = "picProfileIcon";
            this.picProfileIcon.Size = new System.Drawing.Size(142, 136);
            this.picProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfileIcon.TabIndex = 10;
            this.picProfileIcon.TabStop = false;
            // 
            // removeStudent
            // 
            this.removeStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.removeStudent.Location = new System.Drawing.Point(186, 0);
            this.removeStudent.Name = "removeStudent";
            this.removeStudent.Size = new System.Drawing.Size(1078, 681);
            this.removeStudent.TabIndex = 14;
            this.removeStudent.Visible = false;
            // 
            // enrolment_Request
            // 
            this.enrolment_Request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.enrolment_Request.Location = new System.Drawing.Point(186, 0);
            this.enrolment_Request.Name = "enrolment_Request";
            this.enrolment_Request.Size = new System.Drawing.Size(1078, 681);
            this.enrolment_Request.TabIndex = 13;
            this.enrolment_Request.Visible = false;
            // 
            // update_Enrolment
            // 
            this.update_Enrolment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.update_Enrolment.Location = new System.Drawing.Point(186, 0);
            this.update_Enrolment.Name = "update_Enrolment";
            this.update_Enrolment.Size = new System.Drawing.Size(1078, 681);
            this.update_Enrolment.TabIndex = 12;
            this.update_Enrolment.Visible = false;
            // 
            // register_and_Ennrol
            // 
            this.register_and_Ennrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.register_and_Ennrol.Location = new System.Drawing.Point(186, 0);
            this.register_and_Ennrol.Name = "register_and_Ennrol";
            this.register_and_Ennrol.Size = new System.Drawing.Size(1078, 681);
            this.register_and_Ennrol.TabIndex = 11;
            this.register_and_Ennrol.Visible = false;
            // 
            // lecturer_Profile1
            // 
            this.lecturer_Profile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.lecturer_Profile1.Location = new System.Drawing.Point(186, 269);
            this.lecturer_Profile1.Name = "lecturer_Profile1";
            this.lecturer_Profile1.Size = new System.Drawing.Size(1078, 412);
            this.lecturer_Profile1.TabIndex = 15;
            this.lecturer_Profile1.Visible = false;
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lecturer_Profile1);
            this.Controls.Add(this.picProfileIcon);
            this.Controls.Add(this.lblLecturerID);
            this.Controls.Add(this.lblLecturerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFunctionBar);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.register_and_Ennrol);
            this.Controls.Add(this.update_Enrolment);
            this.Controls.Add(this.enrolment_Request);
            this.Controls.Add(this.removeStudent);
            this.Name = "LecturerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LecturerForm_FormClosing);
            this.Load += new System.EventHandler(this.LecturerForm_Load);
            this.panelFunctionBar.ResumeLayout(false);
            this.panelFunctionBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFunctionBar;
        private System.Windows.Forms.PictureBox picMascot;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnHomeScreen;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblLecturerName;
        private System.Windows.Forms.Label lblLecturerID;
        private System.Windows.Forms.PictureBox picProfileIcon;
        private Login.Register_and_Ennrol register_and_Ennrol;
        private Update_Enrolment update_Enrolment;
        private Enrolment_Request enrolment_Request;
        private RemoveStudent removeStudent;
        private Lecturer_Profile lecturer_Profile1;
    }
}