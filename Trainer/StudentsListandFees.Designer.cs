namespace APU_Programming_Cafe.Trainer
{
    partial class StudentsListandFees
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblListInstructions = new System.Windows.Forms.Label();
            this.lblFunctionTitle = new System.Windows.Forms.Label();
            this.lblFeeStatus = new System.Windows.Forms.Label();
            this.listAddStudent = new System.Windows.Forms.ListBox();
            this.datagridStudentsList = new System.Windows.Forms.DataGridView();
            this.lblStudentsList = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpboxStudentInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboClassCode = new System.Windows.Forms.ComboBox();
            this.grpboxAssign = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAssignIntake = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAssignModuleCode = new System.Windows.Forms.ComboBox();
            this.lblSelectClass = new System.Windows.Forms.Label();
            this.cboAssignClass = new System.Windows.Forms.ComboBox();
            this.lblEnrolment = new System.Windows.Forms.Label();
            this.cboModule = new System.Windows.Forms.ComboBox();
            this.cboIntake = new System.Windows.Forms.ComboBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudentsList)).BeginInit();
            this.grpboxStudentInfo.SuspendLayout();
            this.grpboxAssign.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(624, 610);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 55);
            this.btnRefresh.TabIndex = 58;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblListInstructions
            // 
            this.lblListInstructions.AutoSize = true;
            this.lblListInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblListInstructions.ForeColor = System.Drawing.Color.White;
            this.lblListInstructions.Location = new System.Drawing.Point(28, 626);
            this.lblListInstructions.Name = "lblListInstructions";
            this.lblListInstructions.Size = new System.Drawing.Size(312, 24);
            this.lblListInstructions.TabIndex = 53;
            this.lblListInstructions.Text = "Select a class before adding student";
            // 
            // lblFunctionTitle
            // 
            this.lblFunctionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFunctionTitle.AutoSize = true;
            this.lblFunctionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFunctionTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblFunctionTitle.Location = new System.Drawing.Point(382, 16);
            this.lblFunctionTitle.Name = "lblFunctionTitle";
            this.lblFunctionTitle.Size = new System.Drawing.Size(356, 46);
            this.lblFunctionTitle.TabIndex = 42;
            this.lblFunctionTitle.Text = "View List and Fees";
            // 
            // lblFeeStatus
            // 
            this.lblFeeStatus.AutoSize = true;
            this.lblFeeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblFeeStatus.ForeColor = System.Drawing.Color.White;
            this.lblFeeStatus.Location = new System.Drawing.Point(832, 153);
            this.lblFeeStatus.Name = "lblFeeStatus";
            this.lblFeeStatus.Size = new System.Drawing.Size(150, 26);
            this.lblFeeStatus.TabIndex = 63;
            this.lblFeeStatus.Text = "List of students to add to class\r\nDouble click to undo";
            // 
            // listAddStudent
            // 
            this.listAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listAddStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listAddStudent.ForeColor = System.Drawing.Color.Aquamarine;
            this.listAddStudent.FormattingEnabled = true;
            this.listAddStudent.ItemHeight = 20;
            this.listAddStudent.Location = new System.Drawing.Point(835, 187);
            this.listAddStudent.Name = "listAddStudent";
            this.listAddStudent.Size = new System.Drawing.Size(222, 402);
            this.listAddStudent.TabIndex = 62;
            this.listAddStudent.DoubleClick += new System.EventHandler(this.listAddStudent_DoubleClick);
            // 
            // datagridStudentsList
            // 
            this.datagridStudentsList.AllowUserToAddRows = false;
            this.datagridStudentsList.AllowUserToDeleteRows = false;
            this.datagridStudentsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridStudentsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridStudentsList.Location = new System.Drawing.Point(320, 187);
            this.datagridStudentsList.MultiSelect = false;
            this.datagridStudentsList.Name = "datagridStudentsList";
            this.datagridStudentsList.ReadOnly = true;
            this.datagridStudentsList.RowHeadersWidth = 51;
            this.datagridStudentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridStudentsList.Size = new System.Drawing.Size(510, 409);
            this.datagridStudentsList.TabIndex = 61;
            this.datagridStudentsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridStudentsList_CellDoubleClick);
            // 
            // lblStudentsList
            // 
            this.lblStudentsList.AutoSize = true;
            this.lblStudentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblStudentsList.ForeColor = System.Drawing.Color.White;
            this.lblStudentsList.Location = new System.Drawing.Point(314, 153);
            this.lblStudentsList.Name = "lblStudentsList";
            this.lblStudentsList.Size = new System.Drawing.Size(180, 31);
            this.lblStudentsList.TabIndex = 60;
            this.lblStudentsList.Text = "Students List:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClearAll.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClearAll.Location = new System.Drawing.Point(31, 271);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(80, 28);
            this.btnClearAll.TabIndex = 66;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(926, 610);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 65;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // grpboxStudentInfo
            // 
            this.grpboxStudentInfo.Controls.Add(this.label3);
            this.grpboxStudentInfo.Controls.Add(this.cboClassCode);
            this.grpboxStudentInfo.Controls.Add(this.grpboxAssign);
            this.grpboxStudentInfo.Controls.Add(this.btnClearAll);
            this.grpboxStudentInfo.Controls.Add(this.lblEnrolment);
            this.grpboxStudentInfo.Controls.Add(this.cboModule);
            this.grpboxStudentInfo.Controls.Add(this.cboIntake);
            this.grpboxStudentInfo.Controls.Add(this.lblModule);
            this.grpboxStudentInfo.Controls.Add(this.cboLevel);
            this.grpboxStudentInfo.Controls.Add(this.btnApplyFilter);
            this.grpboxStudentInfo.Controls.Add(this.lblLevel);
            this.grpboxStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxStudentInfo.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpboxStudentInfo.Location = new System.Drawing.Point(26, 16);
            this.grpboxStudentInfo.Name = "grpboxStudentInfo";
            this.grpboxStudentInfo.Size = new System.Drawing.Size(279, 604);
            this.grpboxStudentInfo.TabIndex = 77;
            this.grpboxStudentInfo.TabStop = false;
            this.grpboxStudentInfo.Text = "Filter Student:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "ClassCode:";
            // 
            // cboClassCode
            // 
            this.cboClassCode.AllowDrop = true;
            this.cboClassCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClassCode.FormattingEnabled = true;
            this.cboClassCode.Location = new System.Drawing.Point(30, 228);
            this.cboClassCode.Name = "cboClassCode";
            this.cboClassCode.Size = new System.Drawing.Size(216, 28);
            this.cboClassCode.TabIndex = 83;
            // 
            // grpboxAssign
            // 
            this.grpboxAssign.Controls.Add(this.label2);
            this.grpboxAssign.Controls.Add(this.cboAssignIntake);
            this.grpboxAssign.Controls.Add(this.label1);
            this.grpboxAssign.Controls.Add(this.cboAssignModuleCode);
            this.grpboxAssign.Controls.Add(this.lblSelectClass);
            this.grpboxAssign.Controls.Add(this.cboAssignClass);
            this.grpboxAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxAssign.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpboxAssign.Location = new System.Drawing.Point(31, 308);
            this.grpboxAssign.Name = "grpboxAssign";
            this.grpboxAssign.Size = new System.Drawing.Size(215, 280);
            this.grpboxAssign.TabIndex = 82;
            this.grpboxAssign.TabStop = false;
            this.grpboxAssign.Text = "Assign:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "Select Intake:";
            // 
            // cboAssignIntake
            // 
            this.cboAssignIntake.AllowDrop = true;
            this.cboAssignIntake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssignIntake.Enabled = false;
            this.cboAssignIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAssignIntake.FormattingEnabled = true;
            this.cboAssignIntake.Location = new System.Drawing.Point(28, 143);
            this.cboAssignIntake.Name = "cboAssignIntake";
            this.cboAssignIntake.Size = new System.Drawing.Size(158, 34);
            this.cboAssignIntake.TabIndex = 87;
            this.cboAssignIntake.SelectedIndexChanged += new System.EventHandler(this.cboAssignIntake_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Select ModuleCode:";
            // 
            // cboAssignModuleCode
            // 
            this.cboAssignModuleCode.AllowDrop = true;
            this.cboAssignModuleCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssignModuleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAssignModuleCode.FormattingEnabled = true;
            this.cboAssignModuleCode.Location = new System.Drawing.Point(27, 61);
            this.cboAssignModuleCode.Name = "cboAssignModuleCode";
            this.cboAssignModuleCode.Size = new System.Drawing.Size(158, 34);
            this.cboAssignModuleCode.TabIndex = 85;
            this.cboAssignModuleCode.SelectedIndexChanged += new System.EventHandler(this.cboAssignModuleCode_SelectedIndexChanged);
            // 
            // lblSelectClass
            // 
            this.lblSelectClass.AutoSize = true;
            this.lblSelectClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSelectClass.ForeColor = System.Drawing.Color.White;
            this.lblSelectClass.Location = new System.Drawing.Point(22, 195);
            this.lblSelectClass.Name = "lblSelectClass";
            this.lblSelectClass.Size = new System.Drawing.Size(101, 20);
            this.lblSelectClass.TabIndex = 84;
            this.lblSelectClass.Text = "Select Class:";
            // 
            // cboAssignClass
            // 
            this.cboAssignClass.AllowDrop = true;
            this.cboAssignClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssignClass.Enabled = false;
            this.cboAssignClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAssignClass.FormattingEnabled = true;
            this.cboAssignClass.Location = new System.Drawing.Point(27, 221);
            this.cboAssignClass.Name = "cboAssignClass";
            this.cboAssignClass.Size = new System.Drawing.Size(158, 34);
            this.cboAssignClass.TabIndex = 83;
            // 
            // lblEnrolment
            // 
            this.lblEnrolment.AutoSize = true;
            this.lblEnrolment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEnrolment.ForeColor = System.Drawing.Color.White;
            this.lblEnrolment.Location = new System.Drawing.Point(26, 148);
            this.lblEnrolment.Name = "lblEnrolment";
            this.lblEnrolment.Size = new System.Drawing.Size(58, 20);
            this.lblEnrolment.TabIndex = 81;
            this.lblEnrolment.Text = "Intake:";
            // 
            // cboModule
            // 
            this.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Items.AddRange(new object[] {
            "Python",
            "HTML",
            "Java",
            "C#"});
            this.cboModule.Location = new System.Drawing.Point(30, 60);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(216, 28);
            this.cboModule.TabIndex = 64;
            // 
            // cboIntake
            // 
            this.cboIntake.AllowDrop = true;
            this.cboIntake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIntake.FormattingEnabled = true;
            this.cboIntake.Items.AddRange(new object[] {
            "January",
            "April",
            "July",
            "October"});
            this.cboIntake.Location = new System.Drawing.Point(30, 172);
            this.cboIntake.Name = "cboIntake";
            this.cboIntake.Size = new System.Drawing.Size(216, 28);
            this.cboIntake.TabIndex = 80;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblModule.ForeColor = System.Drawing.Color.White;
            this.lblModule.Location = new System.Drawing.Point(26, 36);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(65, 20);
            this.lblModule.TabIndex = 61;
            this.lblModule.Text = "Module:";
            // 
            // cboLevel
            // 
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cboLevel.Location = new System.Drawing.Point(30, 116);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(216, 28);
            this.cboLevel.TabIndex = 79;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnApplyFilter.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnApplyFilter.Location = new System.Drawing.Point(178, 271);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(69, 28);
            this.btnApplyFilter.TabIndex = 59;
            this.btnApplyFilter.Text = "Apply";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(26, 92);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(50, 20);
            this.lblLevel.TabIndex = 78;
            this.lblLevel.Text = "Level:";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAddStudent.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnAddStudent.Location = new System.Drawing.Point(769, 610);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(142, 55);
            this.btnAddStudent.TabIndex = 58;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // StudentsListandFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.grpboxStudentInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblFeeStatus);
            this.Controls.Add(this.listAddStudent);
            this.Controls.Add(this.datagridStudentsList);
            this.Controls.Add(this.lblStudentsList);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblListInstructions);
            this.Controls.Add(this.lblFunctionTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentsListandFees";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.StudentsListandFees_Load);
            this.VisibleChanged += new System.EventHandler(this.StudentsListandFees_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudentsList)).EndInit();
            this.grpboxStudentInfo.ResumeLayout(false);
            this.grpboxStudentInfo.PerformLayout();
            this.grpboxAssign.ResumeLayout(false);
            this.grpboxAssign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblListInstructions;
        private System.Windows.Forms.Label lblFunctionTitle;
        private System.Windows.Forms.Label lblFeeStatus;
        private System.Windows.Forms.ListBox listAddStudent;
        private System.Windows.Forms.DataGridView datagridStudentsList;
        private System.Windows.Forms.Label lblStudentsList;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpboxStudentInfo;
        private System.Windows.Forms.ComboBox cboModule;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label lblEnrolment;
        private System.Windows.Forms.ComboBox cboIntake;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.GroupBox grpboxAssign;
        private System.Windows.Forms.Label lblSelectClass;
        private System.Windows.Forms.ComboBox cboAssignClass;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAssignIntake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAssignModuleCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboClassCode;
    }
}
