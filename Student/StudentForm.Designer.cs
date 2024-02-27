namespace APU_Programming_Cafe.Student
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.picProfileIcon = new System.Windows.Forms.PictureBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFunctionBar = new System.Windows.Forms.Panel();
            this.picMascot = new System.Windows.Forms.PictureBox();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnRequestClass = new System.Windows.Forms.Button();
            this.btnTimetable = new System.Windows.Forms.Button();
            this.btnHomeScreen = new System.Windows.Forms.Button();
            this.lblAppTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileIcon)).BeginInit();
            this.panelFunctionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascot)).BeginInit();
            this.SuspendLayout();
            // 
            // picProfileIcon
            // 
            this.picProfileIcon.Image = ((System.Drawing.Image)(resources.GetObject("picProfileIcon.Image")));
            this.picProfileIcon.Location = new System.Drawing.Point(401, 130);
            this.picProfileIcon.Name = "picProfileIcon";
            this.picProfileIcon.Size = new System.Drawing.Size(142, 136);
            this.picProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfileIcon.TabIndex = 26;
            this.picProfileIcon.TabStop = false;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblStudentID.ForeColor = System.Drawing.Color.White;
            this.lblStudentID.Location = new System.Drawing.Point(571, 205);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(264, 31);
            this.lblStudentID.TabIndex = 25;
            this.lblStudentID.Text = "- Insert StudentID -";
            this.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.White;
            this.lblStudentName.Location = new System.Drawing.Point(569, 148);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(466, 46);
            this.lblStudentName.TabIndex = 24;
            this.lblStudentName.Text = "- Insert Student Name - ";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnProfile.TabIndex = 22;
            this.btnProfile.Text = "View Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(192, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 47);
            this.label1.TabIndex = 23;
            this.label1.Text = "STUDENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFunctionBar
            // 
            this.panelFunctionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.panelFunctionBar.Controls.Add(this.picMascot);
            this.panelFunctionBar.Controls.Add(this.btnPending);
            this.panelFunctionBar.Controls.Add(this.btnPayment);
            this.panelFunctionBar.Controls.Add(this.btnRequestClass);
            this.panelFunctionBar.Controls.Add(this.btnTimetable);
            this.panelFunctionBar.Controls.Add(this.btnHomeScreen);
            this.panelFunctionBar.Controls.Add(this.lblAppTitle);
            this.panelFunctionBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFunctionBar.Location = new System.Drawing.Point(0, 0);
            this.panelFunctionBar.Name = "panelFunctionBar";
            this.panelFunctionBar.Size = new System.Drawing.Size(180, 681);
            this.panelFunctionBar.TabIndex = 27;
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
            // btnPending
            // 
            this.btnPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPending.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnPending.Location = new System.Drawing.Point(0, 493);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(180, 61);
            this.btnPending.TabIndex = 6;
            this.btnPending.Text = "Pending Requests";
            this.btnPending.UseVisualStyleBackColor = false;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnPayment.Location = new System.Drawing.Point(0, 576);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(180, 61);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Payment/Invoice";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnRequestClass
            // 
            this.btnRequestClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnRequestClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestClass.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRequestClass.Location = new System.Drawing.Point(0, 410);
            this.btnRequestClass.Name = "btnRequestClass";
            this.btnRequestClass.Size = new System.Drawing.Size(180, 61);
            this.btnRequestClass.TabIndex = 3;
            this.btnRequestClass.Text = "Request";
            this.btnRequestClass.UseVisualStyleBackColor = false;
            this.btnRequestClass.Click += new System.EventHandler(this.btnRequestClass_Click);
            // 
            // btnTimetable
            // 
            this.btnTimetable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.btnTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimetable.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnTimetable.Location = new System.Drawing.Point(0, 327);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(180, 61);
            this.btnTimetable.TabIndex = 2;
            this.btnTimetable.Text = "Timetable";
            this.btnTimetable.UseVisualStyleBackColor = false;
            this.btnTimetable.Click += new System.EventHandler(this.btnTimetable_Click);
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
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelFunctionBar);
            this.Controls.Add(this.picProfileIcon);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfileIcon)).EndInit();
            this.panelFunctionBar.ResumeLayout(false);
            this.panelFunctionBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProfileIcon;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFunctionBar;
        private System.Windows.Forms.PictureBox picMascot;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnRequestClass;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Button btnHomeScreen;
        private System.Windows.Forms.Label lblAppTitle;
    }
}