namespace APU_Programming_Cafe.Lecturer
{
    partial class RemoveStudent
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
            this.lblFunctionTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblListInstructions1 = new System.Windows.Forms.Label();
            this.lblSearchInstructions = new System.Windows.Forms.Label();
            this.cboMonthFilter = new System.Windows.Forms.ComboBox();
            this.cboYearFilter = new System.Windows.Forms.ComboBox();
            this.cboModuleFilter = new System.Windows.Forms.ComboBox();
            this.cboLevelFilter = new System.Windows.Forms.ComboBox();
            this.lblMonthFilter = new System.Windows.Forms.Label();
            this.lblYearFilter = new System.Windows.Forms.Label();
            this.lblModuleFilter = new System.Windows.Forms.Label();
            this.lblLevelFilter = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listSelectedStudents = new System.Windows.Forms.ListBox();
            this.datagridCompletedStudents = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblEnrolledStudents = new System.Windows.Forms.Label();
            this.lblInstruction3 = new System.Windows.Forms.Label();
            this.btnFilterSearch = new System.Windows.Forms.Button();
            this.grpboxFilter = new System.Windows.Forms.GroupBox();
            this.lblInstructions2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCompletedStudents)).BeginInit();
            this.grpboxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFunctionTitle
            // 
            this.lblFunctionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFunctionTitle.AutoSize = true;
            this.lblFunctionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFunctionTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblFunctionTitle.Location = new System.Drawing.Point(281, 28);
            this.lblFunctionTitle.Name = "lblFunctionTitle";
            this.lblFunctionTitle.Size = new System.Drawing.Size(520, 46);
            this.lblFunctionTitle.TabIndex = 1;
            this.lblFunctionTitle.Text = "Remove Completed Student";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(562, 606);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 55);
            this.btnRefresh.TabIndex = 57;
            this.btnRefresh.Text = "Refresh Table";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClear.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClear.Location = new System.Drawing.Point(770, 606);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 55);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblListInstructions1
            // 
            this.lblListInstructions1.AutoSize = true;
            this.lblListInstructions1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblListInstructions1.ForeColor = System.Drawing.Color.White;
            this.lblListInstructions1.Location = new System.Drawing.Point(577, 108);
            this.lblListInstructions1.Name = "lblListInstructions1";
            this.lblListInstructions1.Size = new System.Drawing.Size(166, 13);
            this.lblListInstructions1.TabIndex = 54;
            this.lblListInstructions1.Text = "List of StudentID To be Removed";
            // 
            // lblSearchInstructions
            // 
            this.lblSearchInstructions.AutoSize = true;
            this.lblSearchInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSearchInstructions.ForeColor = System.Drawing.Color.White;
            this.lblSearchInstructions.Location = new System.Drawing.Point(845, 113);
            this.lblSearchInstructions.Name = "lblSearchInstructions";
            this.lblSearchInstructions.Size = new System.Drawing.Size(107, 13);
            this.lblSearchInstructions.TabIndex = 53;
            this.lblSearchInstructions.Text = "Search for StudentID";
            // 
            // cboMonthFilter
            // 
            this.cboMonthFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonthFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboMonthFilter.FormattingEnabled = true;
            this.cboMonthFilter.Items.AddRange(new object[] {
            "January",
            "April",
            "July",
            "October"});
            this.cboMonthFilter.Location = new System.Drawing.Point(45, 274);
            this.cboMonthFilter.Name = "cboMonthFilter";
            this.cboMonthFilter.Size = new System.Drawing.Size(186, 28);
            this.cboMonthFilter.TabIndex = 52;
            // 
            // cboYearFilter
            // 
            this.cboYearFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboYearFilter.FormattingEnabled = true;
            this.cboYearFilter.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cboYearFilter.Location = new System.Drawing.Point(45, 201);
            this.cboYearFilter.Name = "cboYearFilter";
            this.cboYearFilter.Size = new System.Drawing.Size(186, 28);
            this.cboYearFilter.TabIndex = 51;
            // 
            // cboModuleFilter
            // 
            this.cboModuleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModuleFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboModuleFilter.FormattingEnabled = true;
            this.cboModuleFilter.Items.AddRange(new object[] {
            "Python",
            "HTML",
            "Java",
            "C#"});
            this.cboModuleFilter.Location = new System.Drawing.Point(45, 130);
            this.cboModuleFilter.Name = "cboModuleFilter";
            this.cboModuleFilter.Size = new System.Drawing.Size(186, 28);
            this.cboModuleFilter.TabIndex = 50;
            // 
            // cboLevelFilter
            // 
            this.cboLevelFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboLevelFilter.FormattingEnabled = true;
            this.cboLevelFilter.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cboLevelFilter.Location = new System.Drawing.Point(45, 62);
            this.cboLevelFilter.Name = "cboLevelFilter";
            this.cboLevelFilter.Size = new System.Drawing.Size(186, 28);
            this.cboLevelFilter.TabIndex = 49;
            // 
            // lblMonthFilter
            // 
            this.lblMonthFilter.AutoSize = true;
            this.lblMonthFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMonthFilter.ForeColor = System.Drawing.Color.White;
            this.lblMonthFilter.Location = new System.Drawing.Point(41, 248);
            this.lblMonthFilter.Name = "lblMonthFilter";
            this.lblMonthFilter.Size = new System.Drawing.Size(135, 20);
            this.lblMonthFilter.TabIndex = 48;
            this.lblMonthFilter.Text = "Enrolment Month:";
            // 
            // lblYearFilter
            // 
            this.lblYearFilter.AutoSize = true;
            this.lblYearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblYearFilter.ForeColor = System.Drawing.Color.White;
            this.lblYearFilter.Location = new System.Drawing.Point(41, 175);
            this.lblYearFilter.Name = "lblYearFilter";
            this.lblYearFilter.Size = new System.Drawing.Size(124, 20);
            this.lblYearFilter.TabIndex = 47;
            this.lblYearFilter.Text = "Enrolment Year:";
            // 
            // lblModuleFilter
            // 
            this.lblModuleFilter.AutoSize = true;
            this.lblModuleFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblModuleFilter.ForeColor = System.Drawing.Color.White;
            this.lblModuleFilter.Location = new System.Drawing.Point(41, 104);
            this.lblModuleFilter.Name = "lblModuleFilter";
            this.lblModuleFilter.Size = new System.Drawing.Size(65, 20);
            this.lblModuleFilter.TabIndex = 46;
            this.lblModuleFilter.Text = "Module:";
            // 
            // lblLevelFilter
            // 
            this.lblLevelFilter.AutoSize = true;
            this.lblLevelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLevelFilter.ForeColor = System.Drawing.Color.White;
            this.lblLevelFilter.Location = new System.Drawing.Point(41, 36);
            this.lblLevelFilter.Name = "lblLevelFilter";
            this.lblLevelFilter.Size = new System.Drawing.Size(50, 20);
            this.lblLevelFilter.TabIndex = 45;
            this.lblLevelFilter.Text = "Level:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSearch.Location = new System.Drawing.Point(992, 161);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 28);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(778, 132);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 20);
            this.lblSearch.TabIndex = 43;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(848, 129);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(213, 26);
            this.txtSearch.TabIndex = 42;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // listSelectedStudents
            // 
            this.listSelectedStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listSelectedStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listSelectedStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listSelectedStudents.ForeColor = System.Drawing.Color.Aquamarine;
            this.listSelectedStudents.FormattingEnabled = true;
            this.listSelectedStudents.ItemHeight = 20;
            this.listSelectedStudents.Location = new System.Drawing.Point(580, 126);
            this.listSelectedStudents.Name = "listSelectedStudents";
            this.listSelectedStudents.Size = new System.Drawing.Size(192, 462);
            this.listSelectedStudents.TabIndex = 41;
            this.listSelectedStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSelectedStudents_MouseDoubleClick);
            // 
            // datagridCompletedStudents
            // 
            this.datagridCompletedStudents.AllowUserToAddRows = false;
            this.datagridCompletedStudents.AllowUserToDeleteRows = false;
            this.datagridCompletedStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridCompletedStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridCompletedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCompletedStudents.Location = new System.Drawing.Point(23, 126);
            this.datagridCompletedStudents.MultiSelect = false;
            this.datagridCompletedStudents.Name = "datagridCompletedStudents";
            this.datagridCompletedStudents.ReadOnly = true;
            this.datagridCompletedStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridCompletedStudents.Size = new System.Drawing.Size(542, 462);
            this.datagridCompletedStudents.TabIndex = 40;
            
            this.datagridCompletedStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridCompletedStudents_CellDoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(23, 606);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRemove.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRemove.Location = new System.Drawing.Point(909, 606);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(131, 55);
            this.btnRemove.TabIndex = 38;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblEnrolledStudents
            // 
            this.lblEnrolledStudents.AutoSize = true;
            this.lblEnrolledStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblEnrolledStudents.ForeColor = System.Drawing.Color.White;
            this.lblEnrolledStudents.Location = new System.Drawing.Point(17, 81);
            this.lblEnrolledStudents.Name = "lblEnrolledStudents";
            this.lblEnrolledStudents.Size = new System.Drawing.Size(268, 31);
            this.lblEnrolledStudents.TabIndex = 37;
            this.lblEnrolledStudents.Text = "Completed Students:";
            // 
            // lblInstruction3
            // 
            this.lblInstruction3.AutoSize = true;
            this.lblInstruction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblInstruction3.ForeColor = System.Drawing.Color.White;
            this.lblInstruction3.Location = new System.Drawing.Point(291, 96);
            this.lblInstruction3.Name = "lblInstruction3";
            this.lblInstruction3.Size = new System.Drawing.Size(184, 13);
            this.lblInstruction3.TabIndex = 58;
            this.lblInstruction3.Text = "Double Click a Row of Data to Select";
            // 
            // btnFilterSearch
            // 
            this.btnFilterSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFilterSearch.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnFilterSearch.Location = new System.Drawing.Point(45, 322);
            this.btnFilterSearch.Name = "btnFilterSearch";
            this.btnFilterSearch.Size = new System.Drawing.Size(69, 28);
            this.btnFilterSearch.TabIndex = 59;
            this.btnFilterSearch.Text = "Search";
            this.btnFilterSearch.UseVisualStyleBackColor = true;
            this.btnFilterSearch.Click += new System.EventHandler(this.btnFilterSearch_Click);
            // 
            // grpboxFilter
            // 
            this.grpboxFilter.Controls.Add(this.cboMonthFilter);
            this.grpboxFilter.Controls.Add(this.btnFilterSearch);
            this.grpboxFilter.Controls.Add(this.lblLevelFilter);
            this.grpboxFilter.Controls.Add(this.lblModuleFilter);
            this.grpboxFilter.Controls.Add(this.lblYearFilter);
            this.grpboxFilter.Controls.Add(this.lblMonthFilter);
            this.grpboxFilter.Controls.Add(this.cboLevelFilter);
            this.grpboxFilter.Controls.Add(this.cboModuleFilter);
            this.grpboxFilter.Controls.Add(this.cboYearFilter);
            this.grpboxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxFilter.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpboxFilter.Location = new System.Drawing.Point(782, 195);
            this.grpboxFilter.Name = "grpboxFilter";
            this.grpboxFilter.Size = new System.Drawing.Size(279, 371);
            this.grpboxFilter.TabIndex = 60;
            this.grpboxFilter.TabStop = false;
            this.grpboxFilter.Text = "Filter:";
            // 
            // lblInstructions2
            // 
            this.lblInstructions2.AutoSize = true;
            this.lblInstructions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblInstructions2.ForeColor = System.Drawing.Color.White;
            this.lblInstructions2.Location = new System.Drawing.Point(577, 88);
            this.lblInstructions2.Name = "lblInstructions2";
            this.lblInstructions2.Size = new System.Drawing.Size(199, 13);
            this.lblInstructions2.TabIndex = 61;
            this.lblInstructions2.Text = "Double Click to remove Student from List";
            // 
            // RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.lblInstructions2);
            this.Controls.Add(this.grpboxFilter);
            this.Controls.Add(this.lblInstruction3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblListInstructions1);
            this.Controls.Add(this.lblSearchInstructions);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listSelectedStudents);
            this.Controls.Add(this.datagridCompletedStudents);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblEnrolledStudents);
            this.Controls.Add(this.lblFunctionTitle);
            this.Name = "RemoveStudent";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.RemoveStudent_Load);
            this.VisibleChanged += new System.EventHandler(this.RemoveStudent_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.datagridCompletedStudents)).EndInit();
            this.grpboxFilter.ResumeLayout(false);
            this.grpboxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFunctionTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblListInstructions1;
        private System.Windows.Forms.Label lblSearchInstructions;
        private System.Windows.Forms.ComboBox cboMonthFilter;
        private System.Windows.Forms.ComboBox cboYearFilter;
        private System.Windows.Forms.ComboBox cboModuleFilter;
        private System.Windows.Forms.ComboBox cboLevelFilter;
        private System.Windows.Forms.Label lblMonthFilter;
        private System.Windows.Forms.Label lblYearFilter;
        private System.Windows.Forms.Label lblModuleFilter;
        private System.Windows.Forms.Label lblLevelFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listSelectedStudents;
        private System.Windows.Forms.DataGridView datagridCompletedStudents;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblEnrolledStudents;
        private System.Windows.Forms.Label lblInstruction3;
        private System.Windows.Forms.Button btnFilterSearch;
        private System.Windows.Forms.GroupBox grpboxFilter;
        private System.Windows.Forms.Label lblInstructions2;
    }
}
