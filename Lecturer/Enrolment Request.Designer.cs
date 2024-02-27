namespace APU_Programming_Cafe.Lecturer
{
    partial class Enrolment_Request
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
            this.listSelectedStudents = new System.Windows.Forms.ListBox();
            this.lblRequestedStudent = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.datagridRequestedStudents = new System.Windows.Forms.DataGridView();
            this.cboEnrolmentMonth = new System.Windows.Forms.ComboBox();
            this.cboEnrolmentYear = new System.Windows.Forms.ComboBox();
            this.lblEnrolmentMonth = new System.Windows.Forms.Label();
            this.lblEnrolmentYear = new System.Windows.Forms.Label();
            this.lblListInstructions = new System.Windows.Forms.Label();
            this.lblSearchInstructions = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridRequestedStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFunctionTitle
            // 
            this.lblFunctionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFunctionTitle.AutoSize = true;
            this.lblFunctionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFunctionTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblFunctionTitle.Location = new System.Drawing.Point(367, 36);
            this.lblFunctionTitle.Name = "lblFunctionTitle";
            this.lblFunctionTitle.Size = new System.Drawing.Size(381, 46);
            this.lblFunctionTitle.TabIndex = 1;
            this.lblFunctionTitle.Text = "Enrolment Requests";
            // 
            // listSelectedStudents
            // 
            this.listSelectedStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listSelectedStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listSelectedStudents.ForeColor = System.Drawing.Color.White;
            this.listSelectedStudents.FormattingEnabled = true;
            this.listSelectedStudents.ItemHeight = 25;
            this.listSelectedStudents.Location = new System.Drawing.Point(659, 162);
            this.listSelectedStudents.Name = "listSelectedStudents";
            this.listSelectedStudents.Size = new System.Drawing.Size(199, 329);
            this.listSelectedStudents.TabIndex = 3;
            // 
            // lblRequestedStudent
            // 
            this.lblRequestedStudent.AutoSize = true;
            this.lblRequestedStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblRequestedStudent.ForeColor = System.Drawing.Color.White;
            this.lblRequestedStudent.Location = new System.Drawing.Point(17, 114);
            this.lblRequestedStudent.Name = "lblRequestedStudent";
            this.lblRequestedStudent.Size = new System.Drawing.Size(255, 31);
            this.lblRequestedStudent.TabIndex = 4;
            this.lblRequestedStudent.Text = "Requested Student:";
            // 
            // btnApprove
            // 
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnApprove.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnApprove.Location = new System.Drawing.Point(918, 609);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(131, 55);
            this.btnApprove.TabIndex = 17;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClearAll.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClearAll.Location = new System.Drawing.Point(626, 609);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(131, 55);
            this.btnClearAll.TabIndex = 18;
            this.btnClearAll.Text = "Clear";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(23, 609);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // datagridRequestedStudents
            // 
            this.datagridRequestedStudents.AllowUserToAddRows = false;
            this.datagridRequestedStudents.AllowUserToDeleteRows = false;
            this.datagridRequestedStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridRequestedStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridRequestedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridRequestedStudents.Location = new System.Drawing.Point(23, 162);
            this.datagridRequestedStudents.Name = "datagridRequestedStudents";
            this.datagridRequestedStudents.ReadOnly = true;
            this.datagridRequestedStudents.Size = new System.Drawing.Size(621, 329);
            this.datagridRequestedStudents.TabIndex = 21;
            // 
            // cboEnrolmentMonth
            // 
            this.cboEnrolmentMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnrolmentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboEnrolmentMonth.FormattingEnabled = true;
            this.cboEnrolmentMonth.Items.AddRange(new object[] {
            "January",
            "April",
            "July",
            "October"});
            this.cboEnrolmentMonth.Location = new System.Drawing.Point(869, 185);
            this.cboEnrolmentMonth.Name = "cboEnrolmentMonth";
            this.cboEnrolmentMonth.Size = new System.Drawing.Size(186, 28);
            this.cboEnrolmentMonth.TabIndex = 34;
            // 
            // cboEnrolmentYear
            // 
            this.cboEnrolmentYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnrolmentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboEnrolmentYear.FormattingEnabled = true;
            this.cboEnrolmentYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cboEnrolmentYear.Location = new System.Drawing.Point(869, 257);
            this.cboEnrolmentYear.Name = "cboEnrolmentYear";
            this.cboEnrolmentYear.Size = new System.Drawing.Size(186, 28);
            this.cboEnrolmentYear.TabIndex = 33;
            // 
            // lblEnrolmentMonth
            // 
            this.lblEnrolmentMonth.AutoSize = true;
            this.lblEnrolmentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEnrolmentMonth.ForeColor = System.Drawing.Color.White;
            this.lblEnrolmentMonth.Location = new System.Drawing.Point(865, 162);
            this.lblEnrolmentMonth.Name = "lblEnrolmentMonth";
            this.lblEnrolmentMonth.Size = new System.Drawing.Size(135, 20);
            this.lblEnrolmentMonth.TabIndex = 32;
            this.lblEnrolmentMonth.Text = "Enrolment Month:";
            // 
            // lblEnrolmentYear
            // 
            this.lblEnrolmentYear.AutoSize = true;
            this.lblEnrolmentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEnrolmentYear.ForeColor = System.Drawing.Color.White;
            this.lblEnrolmentYear.Location = new System.Drawing.Point(865, 234);
            this.lblEnrolmentYear.Name = "lblEnrolmentYear";
            this.lblEnrolmentYear.Size = new System.Drawing.Size(124, 20);
            this.lblEnrolmentYear.TabIndex = 31;
            this.lblEnrolmentYear.Text = "Enrolment Year:";
            // 
            // lblListInstructions
            // 
            this.lblListInstructions.AutoSize = true;
            this.lblListInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblListInstructions.ForeColor = System.Drawing.Color.White;
            this.lblListInstructions.Location = new System.Drawing.Point(654, 502);
            this.lblListInstructions.Name = "lblListInstructions";
            this.lblListInstructions.Size = new System.Drawing.Size(316, 26);
            this.lblListInstructions.TabIndex = 35;
            this.lblListInstructions.Text = "List of Students - Click to select";
            // 
            // lblSearchInstructions
            // 
            this.lblSearchInstructions.AutoSize = true;
            this.lblSearchInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSearchInstructions.ForeColor = System.Drawing.Color.White;
            this.lblSearchInstructions.Location = new System.Drawing.Point(121, 511);
            this.lblSearchInstructions.Name = "lblSearchInstructions";
            this.lblSearchInstructions.Size = new System.Drawing.Size(107, 13);
            this.lblSearchInstructions.TabIndex = 39;
            this.lblSearchInstructions.Text = "Search for StudentID";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(31, 530);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(87, 26);
            this.lblSearch.TabIndex = 37;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtSearch.Location = new System.Drawing.Point(124, 527);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(213, 32);
            this.txtSearch.TabIndex = 36;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSearch.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSearch.Location = new System.Drawing.Point(256, 567);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 33);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(480, 609);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 55);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReject
            // 
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnReject.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnReject.Location = new System.Drawing.Point(772, 609);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(131, 55);
            this.btnReject.TabIndex = 41;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // Enrolment_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSearchInstructions);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblListInstructions);
            this.Controls.Add(this.cboEnrolmentMonth);
            this.Controls.Add(this.cboEnrolmentYear);
            this.Controls.Add(this.lblEnrolmentMonth);
            this.Controls.Add(this.lblEnrolmentYear);
            this.Controls.Add(this.datagridRequestedStudents);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lblRequestedStudent);
            this.Controls.Add(this.listSelectedStudents);
            this.Controls.Add(this.lblFunctionTitle);
            this.Name = "Enrolment_Request";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.Enrolment_Request_Load);
            this.VisibleChanged += new System.EventHandler(this.Enrolment_Request_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.datagridRequestedStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFunctionTitle;
        private System.Windows.Forms.ListBox listSelectedStudents;
        private System.Windows.Forms.Label lblRequestedStudent;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView datagridRequestedStudents;
        private System.Windows.Forms.ComboBox cboEnrolmentMonth;
        private System.Windows.Forms.ComboBox cboEnrolmentYear;
        private System.Windows.Forms.Label lblEnrolmentMonth;
        private System.Windows.Forms.Label lblEnrolmentYear;
        private System.Windows.Forms.Label lblListInstructions;
        private System.Windows.Forms.Label lblSearchInstructions;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReject;
    }
}
