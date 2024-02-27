namespace APU_Programming_Cafe.Trainer
{
    partial class TrainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerForm));
            this.picMascot = new System.Windows.Forms.PictureBox();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnDeleteClassInfo = new System.Windows.Forms.Button();
            this.btnUpdateClassInfo = new System.Windows.Forms.Button();
            this.btnCoachingClass = new System.Windows.Forms.Button();
            this.btnHomeScreen = new System.Windows.Forms.Button();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.picProfileIcon = new System.Windows.Forms.PictureBox();
            this.lblTrainerID = new System.Windows.Forms.Label();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblTrainer = new System.Windows.Forms.Label();
            this.panelFunctionBar = new System.Windows.Forms.Panel();
            this.btnStudentView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMascot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileIcon)).BeginInit();
            this.panelFunctionBar.SuspendLayout();
            this.SuspendLayout();
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
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnFeedback.Location = new System.Drawing.Point(0, 579);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(180, 61);
            this.btnFeedback.TabIndex = 6;
            this.btnFeedback.Text = "Send Feedback";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnDeleteClassInfo
            // 
            this.btnDeleteClassInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnDeleteClassInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClassInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClassInfo.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnDeleteClassInfo.Location = new System.Drawing.Point(0, 445);
            this.btnDeleteClassInfo.Name = "btnDeleteClassInfo";
            this.btnDeleteClassInfo.Size = new System.Drawing.Size(180, 61);
            this.btnDeleteClassInfo.TabIndex = 5;
            this.btnDeleteClassInfo.Text = "Delete Class";
            this.btnDeleteClassInfo.UseVisualStyleBackColor = false;
            this.btnDeleteClassInfo.Click += new System.EventHandler(this.btnDeleteClassInfo_Click);
            // 
            // btnUpdateClassInfo
            // 
            this.btnUpdateClassInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnUpdateClassInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClassInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClassInfo.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnUpdateClassInfo.Location = new System.Drawing.Point(0, 378);
            this.btnUpdateClassInfo.Name = "btnUpdateClassInfo";
            this.btnUpdateClassInfo.Size = new System.Drawing.Size(180, 61);
            this.btnUpdateClassInfo.TabIndex = 3;
            this.btnUpdateClassInfo.Text = "Update Class Info";
            this.btnUpdateClassInfo.UseVisualStyleBackColor = false;
            this.btnUpdateClassInfo.Click += new System.EventHandler(this.btnUpdateClassInfo_Click);
            // 
            // btnCoachingClass
            // 
            this.btnCoachingClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnCoachingClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoachingClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoachingClass.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnCoachingClass.Location = new System.Drawing.Point(0, 311);
            this.btnCoachingClass.Name = "btnCoachingClass";
            this.btnCoachingClass.Size = new System.Drawing.Size(180, 61);
            this.btnCoachingClass.TabIndex = 2;
            this.btnCoachingClass.Text = "Add Coaching Class";
            this.btnCoachingClass.UseVisualStyleBackColor = false;
            this.btnCoachingClass.Click += new System.EventHandler(this.btnCoachingClass_Click);
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
            // picProfileIcon
            // 
            this.picProfileIcon.Image = ((System.Drawing.Image)(resources.GetObject("picProfileIcon.Image")));
            this.picProfileIcon.Location = new System.Drawing.Point(401, 130);
            this.picProfileIcon.Name = "picProfileIcon";
            this.picProfileIcon.Size = new System.Drawing.Size(142, 136);
            this.picProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfileIcon.TabIndex = 27;
            this.picProfileIcon.TabStop = false;
            // 
            // lblTrainerID
            // 
            this.lblTrainerID.AutoSize = true;
            this.lblTrainerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTrainerID.ForeColor = System.Drawing.Color.White;
            this.lblTrainerID.Location = new System.Drawing.Point(571, 205);
            this.lblTrainerID.Name = "lblTrainerID";
            this.lblTrainerID.Size = new System.Drawing.Size(256, 31);
            this.lblTrainerID.TabIndex = 26;
            this.lblTrainerID.Text = "- Insert TrainerID -";
            this.lblTrainerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.AutoSize = true;
            this.lblTrainerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerName.ForeColor = System.Drawing.Color.White;
            this.lblTrainerName.Location = new System.Drawing.Point(569, 148);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(454, 46);
            this.lblTrainerName.TabIndex = 25;
            this.lblTrainerName.Text = "- Insert Trainer Name - ";
            this.lblTrainerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnProfile.Location = new System.Drawing.Point(366, 298);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(679, 48);
            this.btnProfile.TabIndex = 23;
            this.btnProfile.Text = "View Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblTrainer
            // 
            this.lblTrainer.AutoSize = true;
            this.lblTrainer.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.lblTrainer.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblTrainer.Location = new System.Drawing.Point(192, 12);
            this.lblTrainer.Name = "lblTrainer";
            this.lblTrainer.Size = new System.Drawing.Size(174, 47);
            this.lblTrainer.TabIndex = 24;
            this.lblTrainer.Text = "TRAINER";
            this.lblTrainer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFunctionBar
            // 
            this.panelFunctionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.panelFunctionBar.Controls.Add(this.btnStudentView);
            this.panelFunctionBar.Controls.Add(this.picMascot);
            this.panelFunctionBar.Controls.Add(this.btnFeedback);
            this.panelFunctionBar.Controls.Add(this.btnDeleteClassInfo);
            this.panelFunctionBar.Controls.Add(this.btnUpdateClassInfo);
            this.panelFunctionBar.Controls.Add(this.btnCoachingClass);
            this.panelFunctionBar.Controls.Add(this.btnHomeScreen);
            this.panelFunctionBar.Controls.Add(this.lblAppTitle);
            this.panelFunctionBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFunctionBar.Location = new System.Drawing.Point(0, 0);
            this.panelFunctionBar.Name = "panelFunctionBar";
            this.panelFunctionBar.Size = new System.Drawing.Size(180, 681);
            this.panelFunctionBar.TabIndex = 22;
            // 
            // btnStudentView
            // 
            this.btnStudentView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnStudentView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentView.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnStudentView.Location = new System.Drawing.Point(0, 512);
            this.btnStudentView.Name = "btnStudentView";
            this.btnStudentView.Size = new System.Drawing.Size(180, 61);
            this.btnStudentView.TabIndex = 12;
            this.btnStudentView.Text = "View Student";
            this.btnStudentView.UseVisualStyleBackColor = false;
            this.btnStudentView.Click += new System.EventHandler(this.btnStudentView_Click);
            // 
            // TrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.picProfileIcon);
            this.Controls.Add(this.lblTrainerID);
            this.Controls.Add(this.lblTrainerName);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblTrainer);
            this.Controls.Add(this.panelFunctionBar);
            this.Name = "TrainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainerForm_FormClosing);
            this.Load += new System.EventHandler(this.TrainerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMascot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileIcon)).EndInit();
            this.panelFunctionBar.ResumeLayout(false);
            this.panelFunctionBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMascot;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnDeleteClassInfo;
        private System.Windows.Forms.Button btnUpdateClassInfo;
        private System.Windows.Forms.Button btnCoachingClass;
        private System.Windows.Forms.Button btnHomeScreen;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.PictureBox picProfileIcon;
        private System.Windows.Forms.Label lblTrainerID;
        private System.Windows.Forms.Label lblTrainerName;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblTrainer;
        private System.Windows.Forms.Panel panelFunctionBar;
        private System.Windows.Forms.Button btnStudentView;
    }
}