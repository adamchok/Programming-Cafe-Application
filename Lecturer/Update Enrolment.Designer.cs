namespace APU_Programming_Cafe.Lecturer
{
    partial class Update_Enrolment
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
            this.lblEnrolledStudents = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.datagridEnrolledStudents = new System.Windows.Forms.DataGridView();
            this.listSelectedStudents = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblUpdatedLevel = new System.Windows.Forms.Label();
            this.lblUpdatedModule = new System.Windows.Forms.Label();
            this.lblUpdatedYear = new System.Windows.Forms.Label();
            this.lblUpdatedMonth = new System.Windows.Forms.Label();
            this.cboUpdatedLevel = new System.Windows.Forms.ComboBox();
            this.cboUpdatedModule = new System.Windows.Forms.ComboBox();
            this.cboUpdatedYear = new System.Windows.Forms.ComboBox();
            this.cboUpdatedMonth = new System.Windows.Forms.ComboBox();
            this.lblSearchInstructions = new System.Windows.Forms.Label();
            this.lblListInstructions = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEnrolledStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFunctionTitle
            // 
            this.lblFunctionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFunctionTitle.AutoSize = true;
            this.lblFunctionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFunctionTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblFunctionTitle.Location = new System.Drawing.Point(376, 16);
            this.lblFunctionTitle.Name = "lblFunctionTitle";
            this.lblFunctionTitle.Size = new System.Drawing.Size(341, 46);
            this.lblFunctionTitle.TabIndex = 0;
            this.lblFunctionTitle.Text = "Update Enrolment";
            // 
            // lblEnrolledStudents
            // 
            this.lblEnrolledStudents.AutoSize = true;
            this.lblEnrolledStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblEnrolledStudents.ForeColor = System.Drawing.Color.White;
            this.lblEnrolledStudents.Location = new System.Drawing.Point(20, 78);
            this.lblEnrolledStudents.Name = "lblEnrolledStudents";
            this.lblEnrolledStudents.Size = new System.Drawing.Size(236, 31);
            this.lblEnrolledStudents.TabIndex = 1;
            this.lblEnrolledStudents.Text = "Enrolled Students:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnUpdate.Location = new System.Drawing.Point(913, 603);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 55);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(26, 603);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // datagridEnrolledStudents
            // 
            this.datagridEnrolledStudents.AllowUserToAddRows = false;
            this.datagridEnrolledStudents.AllowUserToDeleteRows = false;
            this.datagridEnrolledStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridEnrolledStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridEnrolledStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridEnrolledStudents.Location = new System.Drawing.Point(26, 123);
            this.datagridEnrolledStudents.MultiSelect = false;
            this.datagridEnrolledStudents.Name = "datagridEnrolledStudents";
            this.datagridEnrolledStudents.ReadOnly = true;
            this.datagridEnrolledStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridEnrolledStudents.Size = new System.Drawing.Size(542, 462);
            this.datagridEnrolledStudents.TabIndex = 18;
            // 
            // listSelectedStudents
            // 
            this.listSelectedStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listSelectedStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listSelectedStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listSelectedStudents.ForeColor = System.Drawing.Color.Aquamarine;
            this.listSelectedStudents.FormattingEnabled = true;
            this.listSelectedStudents.ItemHeight = 20;
            this.listSelectedStudents.Location = new System.Drawing.Point(583, 123);
            this.listSelectedStudents.Name = "listSelectedStudents";
            this.listSelectedStudents.Size = new System.Drawing.Size(192, 462);
            this.listSelectedStudents.TabIndex = 19;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(851, 126);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(213, 26);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(781, 129);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 20);
            this.lblSearch.TabIndex = 21;
            this.lblSearch.Text = "Search:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSearch.Location = new System.Drawing.Point(995, 158);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 28);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblUpdatedLevel
            // 
            this.lblUpdatedLevel.AutoSize = true;
            this.lblUpdatedLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUpdatedLevel.ForeColor = System.Drawing.Color.White;
            this.lblUpdatedLevel.Location = new System.Drawing.Point(781, 225);
            this.lblUpdatedLevel.Name = "lblUpdatedLevel";
            this.lblUpdatedLevel.Size = new System.Drawing.Size(116, 20);
            this.lblUpdatedLevel.TabIndex = 23;
            this.lblUpdatedLevel.Text = "Updated Level:";
            // 
            // lblUpdatedModule
            // 
            this.lblUpdatedModule.AutoSize = true;
            this.lblUpdatedModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUpdatedModule.ForeColor = System.Drawing.Color.White;
            this.lblUpdatedModule.Location = new System.Drawing.Point(781, 293);
            this.lblUpdatedModule.Name = "lblUpdatedModule";
            this.lblUpdatedModule.Size = new System.Drawing.Size(131, 20);
            this.lblUpdatedModule.TabIndex = 24;
            this.lblUpdatedModule.Text = "Updated Module:";
            // 
            // lblUpdatedYear
            // 
            this.lblUpdatedYear.AutoSize = true;
            this.lblUpdatedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUpdatedYear.ForeColor = System.Drawing.Color.White;
            this.lblUpdatedYear.Location = new System.Drawing.Point(781, 364);
            this.lblUpdatedYear.Name = "lblUpdatedYear";
            this.lblUpdatedYear.Size = new System.Drawing.Size(190, 20);
            this.lblUpdatedYear.TabIndex = 25;
            this.lblUpdatedYear.Text = "Updated Enrolment Year:";
            // 
            // lblUpdatedMonth
            // 
            this.lblUpdatedMonth.AutoSize = true;
            this.lblUpdatedMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUpdatedMonth.ForeColor = System.Drawing.Color.White;
            this.lblUpdatedMonth.Location = new System.Drawing.Point(781, 437);
            this.lblUpdatedMonth.Name = "lblUpdatedMonth";
            this.lblUpdatedMonth.Size = new System.Drawing.Size(201, 20);
            this.lblUpdatedMonth.TabIndex = 26;
            this.lblUpdatedMonth.Text = "Updated Enrolment Month:";
            // 
            // cboUpdatedLevel
            // 
            this.cboUpdatedLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdatedLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboUpdatedLevel.FormattingEnabled = true;
            this.cboUpdatedLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cboUpdatedLevel.Location = new System.Drawing.Point(785, 251);
            this.cboUpdatedLevel.Name = "cboUpdatedLevel";
            this.cboUpdatedLevel.Size = new System.Drawing.Size(186, 28);
            this.cboUpdatedLevel.TabIndex = 27;
            // 
            // cboUpdatedModule
            // 
            this.cboUpdatedModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdatedModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboUpdatedModule.FormattingEnabled = true;
            this.cboUpdatedModule.Items.AddRange(new object[] {
            "Python",
            "HTML",
            "Java",
            "C#"});
            this.cboUpdatedModule.Location = new System.Drawing.Point(785, 319);
            this.cboUpdatedModule.Name = "cboUpdatedModule";
            this.cboUpdatedModule.Size = new System.Drawing.Size(186, 28);
            this.cboUpdatedModule.TabIndex = 28;
            // 
            // cboUpdatedYear
            // 
            this.cboUpdatedYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdatedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboUpdatedYear.FormattingEnabled = true;
            this.cboUpdatedYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cboUpdatedYear.Location = new System.Drawing.Point(785, 390);
            this.cboUpdatedYear.Name = "cboUpdatedYear";
            this.cboUpdatedYear.Size = new System.Drawing.Size(186, 28);
            this.cboUpdatedYear.TabIndex = 29;
            // 
            // cboUpdatedMonth
            // 
            this.cboUpdatedMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdatedMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboUpdatedMonth.FormattingEnabled = true;
            this.cboUpdatedMonth.Items.AddRange(new object[] {
            "January",
            "April",
            "July",
            "October"});
            this.cboUpdatedMonth.Location = new System.Drawing.Point(785, 463);
            this.cboUpdatedMonth.Name = "cboUpdatedMonth";
            this.cboUpdatedMonth.Size = new System.Drawing.Size(186, 28);
            this.cboUpdatedMonth.TabIndex = 30;
            // 
            // lblSearchInstructions
            // 
            this.lblSearchInstructions.AutoSize = true;
            this.lblSearchInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSearchInstructions.ForeColor = System.Drawing.Color.White;
            this.lblSearchInstructions.Location = new System.Drawing.Point(848, 110);
            this.lblSearchInstructions.Name = "lblSearchInstructions";
            this.lblSearchInstructions.Size = new System.Drawing.Size(107, 13);
            this.lblSearchInstructions.TabIndex = 31;
            this.lblSearchInstructions.Text = "Search for StudentID";
            // 
            // lblListInstructions
            // 
            this.lblListInstructions.AutoSize = true;
            this.lblListInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblListInstructions.ForeColor = System.Drawing.Color.White;
            this.lblListInstructions.Location = new System.Drawing.Point(580, 105);
            this.lblListInstructions.Name = "lblListInstructions";
            this.lblListInstructions.Size = new System.Drawing.Size(161, 13);
            this.lblListInstructions.TabIndex = 32;
            this.lblListInstructions.Text = "List of StudentID - Click to select";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClear.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClear.Location = new System.Drawing.Point(771, 603);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 55);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblInstructions.ForeColor = System.Drawing.Color.White;
            this.lblInstructions.Location = new System.Drawing.Point(782, 523);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(223, 13);
            this.lblInstructions.TabIndex = 34;
            this.lblInstructions.Text = "Fill in the same choices if there is no mistakes.";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(629, 603);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 55);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Update_Enrolment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblListInstructions);
            this.Controls.Add(this.lblSearchInstructions);
            this.Controls.Add(this.cboUpdatedMonth);
            this.Controls.Add(this.cboUpdatedYear);
            this.Controls.Add(this.cboUpdatedModule);
            this.Controls.Add(this.cboUpdatedLevel);
            this.Controls.Add(this.lblUpdatedMonth);
            this.Controls.Add(this.lblUpdatedYear);
            this.Controls.Add(this.lblUpdatedModule);
            this.Controls.Add(this.lblUpdatedLevel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listSelectedStudents);
            this.Controls.Add(this.datagridEnrolledStudents);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblEnrolledStudents);
            this.Controls.Add(this.lblFunctionTitle);
            this.Name = "Update_Enrolment";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.Update_Enrolment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridEnrolledStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFunctionTitle;
        private System.Windows.Forms.Label lblEnrolledStudents;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView datagridEnrolledStudents;
        private System.Windows.Forms.ListBox listSelectedStudents;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblUpdatedLevel;
        private System.Windows.Forms.Label lblUpdatedModule;
        private System.Windows.Forms.Label lblUpdatedYear;
        private System.Windows.Forms.Label lblUpdatedMonth;
        private System.Windows.Forms.ComboBox cboUpdatedLevel;
        private System.Windows.Forms.ComboBox cboUpdatedModule;
        private System.Windows.Forms.ComboBox cboUpdatedYear;
        private System.Windows.Forms.ComboBox cboUpdatedMonth;
        private System.Windows.Forms.Label lblSearchInstructions;
        private System.Windows.Forms.Label lblListInstructions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnRefresh;
    }
}
