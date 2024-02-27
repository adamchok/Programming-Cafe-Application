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
            this.btnEnrol = new System.Windows.Forms.Button();
            this.picMascot = new System.Windows.Forms.PictureBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnHomeScreen = new System.Windows.Forms.Button();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.picProfileIcon = new System.Windows.Forms.PictureBox();
            this.lblLecturerID = new System.Windows.Forms.Label();
            this.lblLecturerName = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFunctionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFunctionBar
            // 
            this.panelFunctionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.panelFunctionBar.Controls.Add(this.btnEnrol);
            this.panelFunctionBar.Controls.Add(this.picMascot);
            this.panelFunctionBar.Controls.Add(this.btnRequest);
            this.panelFunctionBar.Controls.Add(this.btnRemove);
            this.panelFunctionBar.Controls.Add(this.btnUpdate);
            this.panelFunctionBar.Controls.Add(this.btnRegister);
            this.panelFunctionBar.Controls.Add(this.btnHomeScreen);
            this.panelFunctionBar.Controls.Add(this.lblAppTitle);
            this.panelFunctionBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFunctionBar.Location = new System.Drawing.Point(0, 0);
            this.panelFunctionBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelFunctionBar.Name = "panelFunctionBar";
            this.panelFunctionBar.Size = new System.Drawing.Size(240, 838);
            this.panelFunctionBar.TabIndex = 2;
            // 
            // btnEnrol
            // 
            this.btnEnrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnEnrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrol.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnEnrol.Location = new System.Drawing.Point(0, 466);
            this.btnEnrol.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnrol.Name = "btnEnrol";
            this.btnEnrol.Size = new System.Drawing.Size(240, 75);
            this.btnEnrol.TabIndex = 12;
            this.btnEnrol.Text = "Enrol Student";
            this.btnEnrol.UseVisualStyleBackColor = false;
            this.btnEnrol.Click += new System.EventHandler(this.btnEnrol_Click);
            // 
            // picMascot
            // 
            this.picMascot.Image = ((System.Drawing.Image)(resources.GetObject("picMascot.Image")));
            this.picMascot.Location = new System.Drawing.Point(16, 11);
            this.picMascot.Margin = new System.Windows.Forms.Padding(4);
            this.picMascot.Name = "picMascot";
            this.picMascot.Size = new System.Drawing.Size(207, 142);
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
            this.btnRequest.Location = new System.Drawing.Point(0, 632);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(240, 75);
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
            this.btnRemove.Location = new System.Drawing.Point(0, 715);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(240, 75);
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
            this.btnUpdate.Location = new System.Drawing.Point(0, 549);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(240, 75);
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
            this.btnRegister.Location = new System.Drawing.Point(0, 383);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(240, 75);
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
            this.btnHomeScreen.Location = new System.Drawing.Point(0, 300);
            this.btnHomeScreen.Margin = new System.Windows.Forms.Padding(4);
            this.btnHomeScreen.Name = "btnHomeScreen";
            this.btnHomeScreen.Size = new System.Drawing.Size(240, 75);
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
            this.lblAppTitle.Location = new System.Drawing.Point(16, 169);
            this.lblAppTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(191, 108);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "APU\r\nProgramming\r\nCafe\r\n";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picProfileIcon
            // 
            this.picProfileIcon.Image = ((System.Drawing.Image)(resources.GetObject("picProfileIcon.Image")));
            this.picProfileIcon.Location = new System.Drawing.Point(535, 160);
            this.picProfileIcon.Margin = new System.Windows.Forms.Padding(4);
            this.picProfileIcon.Name = "picProfileIcon";
            this.picProfileIcon.Size = new System.Drawing.Size(189, 167);
            this.picProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfileIcon.TabIndex = 21;
            this.picProfileIcon.TabStop = false;
            // 
            // lblLecturerID
            // 
            this.lblLecturerID.AutoSize = true;
            this.lblLecturerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblLecturerID.ForeColor = System.Drawing.Color.White;
            this.lblLecturerID.Location = new System.Drawing.Point(761, 252);
            this.lblLecturerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLecturerID.Name = "lblLecturerID";
            this.lblLecturerID.Size = new System.Drawing.Size(331, 39);
            this.lblLecturerID.TabIndex = 20;
            this.lblLecturerID.Text = "- Insert LecturerID -";
            this.lblLecturerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLecturerName
            // 
            this.lblLecturerName.AutoSize = true;
            this.lblLecturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturerName.ForeColor = System.Drawing.Color.White;
            this.lblLecturerName.Location = new System.Drawing.Point(759, 182);
            this.lblLecturerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLecturerName.Name = "lblLecturerName";
            this.lblLecturerName.Size = new System.Drawing.Size(594, 58);
            this.lblLecturerName.TabIndex = 19;
            this.lblLecturerName.Text = "- Insert Lecturer Name - ";
            this.lblLecturerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnProfile.Location = new System.Drawing.Point(488, 367);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(905, 59);
            this.btnProfile.TabIndex = 17;
            this.btnProfile.Text = "View Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(256, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 59);
            this.label1.TabIndex = 18;
            this.label1.Text = "LECTURER\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.picProfileIcon);
            this.Controls.Add(this.lblLecturerID);
            this.Controls.Add(this.lblLecturerName);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFunctionBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LecturerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturer ";
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
        private System.Windows.Forms.PictureBox picProfileIcon;
        private System.Windows.Forms.Label lblLecturerID;
        private System.Windows.Forms.Label lblLecturerName;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnrol;
    }
}