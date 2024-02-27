namespace APU_Programming_Cafe.Lecturer
{
    partial class Enrol
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
            this.btnClearAll = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblYearOfEnrolment = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboModule = new System.Windows.Forms.ComboBox();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.lblMonthOfEnrolment = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblFunctionTitle = new System.Windows.Forms.Label();
            this.lblListInstructions = new System.Windows.Forms.Label();
            this.listSelectedStudents = new System.Windows.Forms.ListBox();
            this.datagridEnrolledStudents = new System.Windows.Forms.DataGridView();
            this.lblEnrolledStudents = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSearchInstructions = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEnrolledStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClearAll.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClearAll.Location = new System.Drawing.Point(627, 609);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(131, 55);
            this.btnClearAll.TabIndex = 46;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // cboYear
            // 
            this.cboYear.AllowDrop = true;
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cboYear.Location = new System.Drawing.Point(768, 382);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(290, 33);
            this.cboYear.TabIndex = 43;
            // 
            // lblYearOfEnrolment
            // 
            this.lblYearOfEnrolment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYearOfEnrolment.AutoSize = true;
            this.lblYearOfEnrolment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblYearOfEnrolment.ForeColor = System.Drawing.Color.White;
            this.lblYearOfEnrolment.Location = new System.Drawing.Point(763, 350);
            this.lblYearOfEnrolment.Name = "lblYearOfEnrolment";
            this.lblYearOfEnrolment.Size = new System.Drawing.Size(212, 29);
            this.lblYearOfEnrolment.TabIndex = 42;
            this.lblYearOfEnrolment.Text = "Year of Enrolment:";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(777, 609);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSubmit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSubmit.Location = new System.Drawing.Point(927, 609);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 55);
            this.btnSubmit.TabIndex = 40;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cboMonth
            // 
            this.cboMonth.AllowDrop = true;
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "January",
            "April",
            "July",
            "October"});
            this.cboMonth.Location = new System.Drawing.Point(768, 305);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(291, 33);
            this.cboMonth.TabIndex = 39;
            // 
            // cboModule
            // 
            this.cboModule.AllowDrop = true;
            this.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Items.AddRange(new object[] {
            "Python",
            "HTML",
            "Java",
            "C#"});
            this.cboModule.Location = new System.Drawing.Point(767, 228);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(291, 33);
            this.cboModule.TabIndex = 38;
            // 
            // cboLevel
            // 
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cboLevel.Location = new System.Drawing.Point(768, 151);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(290, 33);
            this.cboLevel.TabIndex = 37;
            // 
            // lblMonthOfEnrolment
            // 
            this.lblMonthOfEnrolment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMonthOfEnrolment.AutoSize = true;
            this.lblMonthOfEnrolment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblMonthOfEnrolment.ForeColor = System.Drawing.Color.White;
            this.lblMonthOfEnrolment.Location = new System.Drawing.Point(762, 273);
            this.lblMonthOfEnrolment.Name = "lblMonthOfEnrolment";
            this.lblMonthOfEnrolment.Size = new System.Drawing.Size(227, 29);
            this.lblMonthOfEnrolment.TabIndex = 32;
            this.lblMonthOfEnrolment.Text = "Month of Enrolment:";
            // 
            // lblModule
            // 
            this.lblModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblModule.ForeColor = System.Drawing.Color.White;
            this.lblModule.Location = new System.Drawing.Point(762, 196);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(100, 29);
            this.lblModule.TabIndex = 31;
            this.lblModule.Text = "Module:";
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(762, 119);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(77, 29);
            this.lblLevel.TabIndex = 30;
            this.lblLevel.Text = "Level:";
            // 
            // lblFunctionTitle
            // 
            this.lblFunctionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFunctionTitle.AutoSize = true;
            this.lblFunctionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFunctionTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblFunctionTitle.Location = new System.Drawing.Point(419, 24);
            this.lblFunctionTitle.Name = "lblFunctionTitle";
            this.lblFunctionTitle.Size = new System.Drawing.Size(218, 46);
            this.lblFunctionTitle.TabIndex = 25;
            this.lblFunctionTitle.Text = "Enrol Form";
            // 
            // lblListInstructions
            // 
            this.lblListInstructions.AutoSize = true;
            this.lblListInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblListInstructions.ForeColor = System.Drawing.Color.White;
            this.lblListInstructions.Location = new System.Drawing.Point(568, 98);
            this.lblListInstructions.Name = "lblListInstructions";
            this.lblListInstructions.Size = new System.Drawing.Size(161, 13);
            this.lblListInstructions.TabIndex = 50;
            this.lblListInstructions.Text = "List of StudentID - Click to select";
            // 
            // listSelectedStudents
            // 
            this.listSelectedStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listSelectedStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listSelectedStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listSelectedStudents.ForeColor = System.Drawing.Color.Aquamarine;
            this.listSelectedStudents.FormattingEnabled = true;
            this.listSelectedStudents.ItemHeight = 20;
            this.listSelectedStudents.Location = new System.Drawing.Point(570, 119);
            this.listSelectedStudents.Name = "listSelectedStudents";
            this.listSelectedStudents.Size = new System.Drawing.Size(174, 462);
            this.listSelectedStudents.TabIndex = 49;
            // 
            // datagridEnrolledStudents
            // 
            this.datagridEnrolledStudents.AllowUserToAddRows = false;
            this.datagridEnrolledStudents.AllowUserToDeleteRows = false;
            this.datagridEnrolledStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridEnrolledStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridEnrolledStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridEnrolledStudents.Location = new System.Drawing.Point(22, 119);
            this.datagridEnrolledStudents.MultiSelect = false;
            this.datagridEnrolledStudents.Name = "datagridEnrolledStudents";
            this.datagridEnrolledStudents.ReadOnly = true;
            this.datagridEnrolledStudents.RowHeadersWidth = 51;
            this.datagridEnrolledStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridEnrolledStudents.Size = new System.Drawing.Size(542, 462);
            this.datagridEnrolledStudents.TabIndex = 48;
            // 
            // lblEnrolledStudents
            // 
            this.lblEnrolledStudents.AutoSize = true;
            this.lblEnrolledStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblEnrolledStudents.ForeColor = System.Drawing.Color.White;
            this.lblEnrolledStudents.Location = new System.Drawing.Point(16, 74);
            this.lblEnrolledStudents.Name = "lblEnrolledStudents";
            this.lblEnrolledStudents.Size = new System.Drawing.Size(261, 31);
            this.lblEnrolledStudents.TabIndex = 47;
            this.lblEnrolledStudents.Text = "Registered Students";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(480, 609);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 55);
            this.btnRefresh.TabIndex = 51;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSearchInstructions
            // 
            this.lblSearchInstructions.AutoSize = true;
            this.lblSearchInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearchInstructions.ForeColor = System.Drawing.Color.White;
            this.lblSearchInstructions.Location = new System.Drawing.Point(841, 453);
            this.lblSearchInstructions.Name = "lblSearchInstructions";
            this.lblSearchInstructions.Size = new System.Drawing.Size(161, 20);
            this.lblSearchInstructions.TabIndex = 55;
            this.lblSearchInstructions.Text = "Search for StudentID";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSearch.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSearch.Location = new System.Drawing.Point(927, 514);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 39);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(752, 478);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(87, 26);
            this.lblSearch.TabIndex = 53;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSearch.Location = new System.Drawing.Point(845, 476);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(213, 29);
            this.txtSearch.TabIndex = 52;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Enrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.lblSearchInstructions);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblListInstructions);
            this.Controls.Add(this.listSelectedStudents);
            this.Controls.Add(this.datagridEnrolledStudents);
            this.Controls.Add(this.lblEnrolledStudents);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.lblYearOfEnrolment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboModule);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.lblMonthOfEnrolment);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblFunctionTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Enrol";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.Enrol_Load);
            this.VisibleChanged += new System.EventHandler(this.Enrol_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.datagridEnrolledStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblYearOfEnrolment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboModule;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.Label lblMonthOfEnrolment;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblFunctionTitle;
        private System.Windows.Forms.Label lblListInstructions;
        private System.Windows.Forms.ListBox listSelectedStudents;
        private System.Windows.Forms.DataGridView datagridEnrolledStudents;
        private System.Windows.Forms.Label lblEnrolledStudents;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSearchInstructions;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
