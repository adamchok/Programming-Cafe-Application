namespace APU_Programming_Cafe.Trainer
{
    partial class AddCoachingClass
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFunctionTitle = new System.Windows.Forms.Label();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.grpboxClassInfo = new System.Windows.Forms.GroupBox();
            this.lblClassNumber = new System.Windows.Forms.Label();
            this.cboClassNumber = new System.Windows.Forms.ComboBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboEndTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblModuleLevel = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblEnrolment = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.cboIntake = new System.Windows.Forms.ComboBox();
            this.cboStartTime = new System.Windows.Forms.ComboBox();
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.cboModuleCode = new System.Windows.Forms.ComboBox();
            this.lblModuleCode = new System.Windows.Forms.Label();
            this.datagridSchedule = new System.Windows.Forms.DataGridView();
            this.lblViewSchedule = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cboSelectDay = new System.Windows.Forms.ComboBox();
            this.lblSelectDay = new System.Windows.Forms.Label();
            this.btnViewCurrentClass = new System.Windows.Forms.Button();
            this.grpboxClassInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(930, 607);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFunctionTitle
            // 
            this.lblFunctionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFunctionTitle.AutoSize = true;
            this.lblFunctionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFunctionTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblFunctionTitle.Location = new System.Drawing.Point(259, 17);
            this.lblFunctionTitle.Name = "lblFunctionTitle";
            this.lblFunctionTitle.Size = new System.Drawing.Size(593, 46);
            this.lblFunctionTitle.TabIndex = 25;
            this.lblFunctionTitle.Text = "Add Coaching Class Information";
            // 
            // btnAddClass
            // 
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddClass.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnAddClass.Location = new System.Drawing.Point(166, 541);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(103, 41);
            this.btnAddClass.TabIndex = 59;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // grpboxClassInfo
            // 
            this.grpboxClassInfo.Controls.Add(this.lblClassNumber);
            this.grpboxClassInfo.Controls.Add(this.cboClassNumber);
            this.grpboxClassInfo.Controls.Add(this.btnClearAll);
            this.grpboxClassInfo.Controls.Add(this.cboVenue);
            this.grpboxClassInfo.Controls.Add(this.btnSearch);
            this.grpboxClassInfo.Controls.Add(this.cboEndTime);
            this.grpboxClassInfo.Controls.Add(this.label1);
            this.grpboxClassInfo.Controls.Add(this.lblStartTime);
            this.grpboxClassInfo.Controls.Add(this.lblModuleLevel);
            this.grpboxClassInfo.Controls.Add(this.lblEndTime);
            this.grpboxClassInfo.Controls.Add(this.lblEnrolment);
            this.grpboxClassInfo.Controls.Add(this.lblDay);
            this.grpboxClassInfo.Controls.Add(this.cboIntake);
            this.grpboxClassInfo.Controls.Add(this.cboStartTime);
            this.grpboxClassInfo.Controls.Add(this.cboDay);
            this.grpboxClassInfo.Controls.Add(this.lblVenue);
            this.grpboxClassInfo.Controls.Add(this.cboModuleCode);
            this.grpboxClassInfo.Controls.Add(this.lblModuleCode);
            this.grpboxClassInfo.Controls.Add(this.btnAddClass);
            this.grpboxClassInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxClassInfo.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpboxClassInfo.Location = new System.Drawing.Point(17, 66);
            this.grpboxClassInfo.Name = "grpboxClassInfo";
            this.grpboxClassInfo.Size = new System.Drawing.Size(298, 596);
            this.grpboxClassInfo.TabIndex = 61;
            this.grpboxClassInfo.TabStop = false;
            this.grpboxClassInfo.Text = "Class Info:";
            // 
            // lblClassNumber
            // 
            this.lblClassNumber.AutoSize = true;
            this.lblClassNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClassNumber.ForeColor = System.Drawing.Color.White;
            this.lblClassNumber.Location = new System.Drawing.Point(15, 470);
            this.lblClassNumber.Name = "lblClassNumber";
            this.lblClassNumber.Size = new System.Drawing.Size(112, 20);
            this.lblClassNumber.TabIndex = 78;
            this.lblClassNumber.Text = "Class Number:";
            this.lblClassNumber.Visible = false;
            // 
            // cboClassNumber
            // 
            this.cboClassNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboClassNumber.FormattingEnabled = true;
            this.cboClassNumber.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cboClassNumber.Location = new System.Drawing.Point(20, 496);
            this.cboClassNumber.Name = "cboClassNumber";
            this.cboClassNumber.Size = new System.Drawing.Size(103, 28);
            this.cboClassNumber.TabIndex = 79;
            this.cboClassNumber.Visible = false;
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClearAll.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClearAll.Location = new System.Drawing.Point(17, 541);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(103, 41);
            this.btnClearAll.TabIndex = 77;
            this.btnClearAll.Text = "ClearAll";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // cboVenue
            // 
            this.cboVenue.AllowDrop = true;
            this.cboVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVenue.FormattingEnabled = true;
            this.cboVenue.Location = new System.Drawing.Point(18, 433);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(249, 28);
            this.cboVenue.TabIndex = 76;
            this.cboVenue.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSearch.Location = new System.Drawing.Point(125, 390);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 32);
            this.btnSearch.TabIndex = 75;
            this.btnSearch.Text = "Search for venue";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboEndTime
            // 
            this.cboEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboEndTime.FormattingEnabled = true;
            this.cboEndTime.Items.AddRange(new object[] {
            "0900",
            "1000",
            "1100",
            "1200",
            "1300",
            "1400",
            "1500",
            "1600",
            "1700",
            "1800"});
            this.cboEndTime.Location = new System.Drawing.Point(165, 350);
            this.cboEndTime.Name = "cboEndTime";
            this.cboEndTime.Size = new System.Drawing.Size(103, 28);
            this.cboEndTime.TabIndex = 65;
            this.cboEndTime.Visible = false;
            this.cboEndTime.SelectedIndexChanged += new System.EventHandler(this.cboEndTime_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Module and Level:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStartTime.ForeColor = System.Drawing.Color.White;
            this.lblStartTime.Location = new System.Drawing.Point(13, 324);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(86, 20);
            this.lblStartTime.TabIndex = 62;
            this.lblStartTime.Text = "Start Time:";
            this.lblStartTime.Visible = false;
            // 
            // lblModuleLevel
            // 
            this.lblModuleLevel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblModuleLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModuleLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblModuleLevel.ForeColor = System.Drawing.Color.Black;
            this.lblModuleLevel.Location = new System.Drawing.Point(19, 145);
            this.lblModuleLevel.Name = "lblModuleLevel";
            this.lblModuleLevel.Size = new System.Drawing.Size(248, 28);
            this.lblModuleLevel.TabIndex = 73;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEndTime.ForeColor = System.Drawing.Color.White;
            this.lblEndTime.Location = new System.Drawing.Point(161, 324);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(80, 20);
            this.lblEndTime.TabIndex = 62;
            this.lblEndTime.Text = "End Time:";
            this.lblEndTime.Visible = false;
            // 
            // lblEnrolment
            // 
            this.lblEnrolment.AutoSize = true;
            this.lblEnrolment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblEnrolment.ForeColor = System.Drawing.Color.White;
            this.lblEnrolment.Location = new System.Drawing.Point(13, 185);
            this.lblEnrolment.Name = "lblEnrolment";
            this.lblEnrolment.Size = new System.Drawing.Size(76, 25);
            this.lblEnrolment.TabIndex = 72;
            this.lblEnrolment.Text = "Intake:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(13, 252);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(56, 25);
            this.lblDay.TabIndex = 62;
            this.lblDay.Text = "Day:";
            this.lblDay.Visible = false;
            // 
            // cboIntake
            // 
            this.cboIntake.AllowDrop = true;
            this.cboIntake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIntake.Enabled = false;
            this.cboIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIntake.FormattingEnabled = true;
            this.cboIntake.Location = new System.Drawing.Point(18, 215);
            this.cboIntake.Name = "cboIntake";
            this.cboIntake.Size = new System.Drawing.Size(249, 28);
            this.cboIntake.TabIndex = 71;
            this.cboIntake.SelectedIndexChanged += new System.EventHandler(this.cboIntake_SelectedIndexChanged);
            // 
            // cboStartTime
            // 
            this.cboStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboStartTime.FormattingEnabled = true;
            this.cboStartTime.Items.AddRange(new object[] {
            "0800",
            "0900",
            "1000",
            "1100",
            "1200",
            "1300",
            "1400",
            "1500",
            "1600",
            "1700"});
            this.cboStartTime.Location = new System.Drawing.Point(18, 350);
            this.cboStartTime.Name = "cboStartTime";
            this.cboStartTime.Size = new System.Drawing.Size(103, 28);
            this.cboStartTime.TabIndex = 65;
            this.cboStartTime.Visible = false;
            this.cboStartTime.SelectedIndexChanged += new System.EventHandler(this.cboStartTime_SelectedIndexChanged);
            // 
            // cboDay
            // 
            this.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboDay.FormattingEnabled = true;
            this.cboDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cboDay.Location = new System.Drawing.Point(18, 278);
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(249, 28);
            this.cboDay.TabIndex = 65;
            this.cboDay.Visible = false;
            this.cboDay.SelectedIndexChanged += new System.EventHandler(this.cboDay_SelectedIndexChanged);
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblVenue.ForeColor = System.Drawing.Color.White;
            this.lblVenue.Location = new System.Drawing.Point(13, 405);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(80, 25);
            this.lblVenue.TabIndex = 67;
            this.lblVenue.Text = "Venue:";
            this.lblVenue.Visible = false;
            // 
            // cboModuleCode
            // 
            this.cboModuleCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModuleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboModuleCode.FormattingEnabled = true;
            this.cboModuleCode.Location = new System.Drawing.Point(20, 76);
            this.cboModuleCode.Name = "cboModuleCode";
            this.cboModuleCode.Size = new System.Drawing.Size(249, 28);
            this.cboModuleCode.TabIndex = 64;
            this.cboModuleCode.SelectedIndexChanged += new System.EventHandler(this.cboModuleCode_SelectedIndexChanged);
            // 
            // lblModuleCode
            // 
            this.lblModuleCode.AutoSize = true;
            this.lblModuleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleCode.ForeColor = System.Drawing.Color.White;
            this.lblModuleCode.Location = new System.Drawing.Point(15, 50);
            this.lblModuleCode.Name = "lblModuleCode";
            this.lblModuleCode.Size = new System.Drawing.Size(140, 25);
            this.lblModuleCode.TabIndex = 61;
            this.lblModuleCode.Text = "ModuleCode:";
            // 
            // datagridSchedule
            // 
            this.datagridSchedule.AllowUserToAddRows = false;
            this.datagridSchedule.AllowUserToDeleteRows = false;
            this.datagridSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSchedule.Location = new System.Drawing.Point(321, 180);
            this.datagridSchedule.MultiSelect = false;
            this.datagridSchedule.Name = "datagridSchedule";
            this.datagridSchedule.ReadOnly = true;
            this.datagridSchedule.RowHeadersWidth = 51;
            this.datagridSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridSchedule.Size = new System.Drawing.Size(740, 410);
            this.datagridSchedule.TabIndex = 63;
            // 
            // lblViewSchedule
            // 
            this.lblViewSchedule.AutoSize = true;
            this.lblViewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblViewSchedule.ForeColor = System.Drawing.Color.White;
            this.lblViewSchedule.Location = new System.Drawing.Point(344, 81);
            this.lblViewSchedule.Name = "lblViewSchedule";
            this.lblViewSchedule.Size = new System.Drawing.Size(314, 31);
            this.lblViewSchedule.TabIndex = 62;
            this.lblViewSchedule.Text = "View All Class Schedule:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(772, 607);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 55);
            this.btnRefresh.TabIndex = 64;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboSelectDay
            // 
            this.cboSelectDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectDay.FormattingEnabled = true;
            this.cboSelectDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cboSelectDay.Location = new System.Drawing.Point(403, 130);
            this.cboSelectDay.Name = "cboSelectDay";
            this.cboSelectDay.Size = new System.Drawing.Size(249, 30);
            this.cboSelectDay.TabIndex = 70;
            this.cboSelectDay.SelectedIndexChanged += new System.EventHandler(this.cboSelectDay_SelectedIndexChanged);
            // 
            // lblSelectDay
            // 
            this.lblSelectDay.AutoSize = true;
            this.lblSelectDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDay.ForeColor = System.Drawing.Color.White;
            this.lblSelectDay.Location = new System.Drawing.Point(345, 130);
            this.lblSelectDay.Name = "lblSelectDay";
            this.lblSelectDay.Size = new System.Drawing.Size(60, 29);
            this.lblSelectDay.TabIndex = 69;
            this.lblSelectDay.Text = "Day:";
            // 
            // btnViewCurrentClass
            // 
            this.btnViewCurrentClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCurrentClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnViewCurrentClass.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewCurrentClass.Location = new System.Drawing.Point(845, 105);
            this.btnViewCurrentClass.Name = "btnViewCurrentClass";
            this.btnViewCurrentClass.Size = new System.Drawing.Size(216, 55);
            this.btnViewCurrentClass.TabIndex = 71;
            this.btnViewCurrentClass.Text = "View Current Class";
            this.btnViewCurrentClass.UseVisualStyleBackColor = true;
            this.btnViewCurrentClass.Click += new System.EventHandler(this.btnViewCurrentClass_Click);
            // 
            // AddCoachingClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnViewCurrentClass);
            this.Controls.Add(this.cboSelectDay);
            this.Controls.Add(this.lblSelectDay);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.datagridSchedule);
            this.Controls.Add(this.lblViewSchedule);
            this.Controls.Add(this.grpboxClassInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblFunctionTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddCoachingClass";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.AddCoachingClass_Load);
            this.VisibleChanged += new System.EventHandler(this.AddCoachingClass_VisibleChanged);
            this.grpboxClassInfo.ResumeLayout(false);
            this.grpboxClassInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFunctionTitle;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.GroupBox grpboxClassInfo;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.ComboBox cboStartTime;
        private System.Windows.Forms.ComboBox cboModuleCode;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblModuleCode;
        private System.Windows.Forms.DataGridView datagridSchedule;
        private System.Windows.Forms.Label lblViewSchedule;
        private System.Windows.Forms.ComboBox cboDay;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cboSelectDay;
        private System.Windows.Forms.Label lblSelectDay;
        private System.Windows.Forms.Label lblEnrolment;
        private System.Windows.Forms.ComboBox cboIntake;
        private System.Windows.Forms.ComboBox cboEndTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModuleLevel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboVenue;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnViewCurrentClass;
        private System.Windows.Forms.Label lblClassNumber;
        private System.Windows.Forms.ComboBox cboClassNumber;
    }
}
