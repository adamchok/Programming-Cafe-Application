namespace APU_Programming_Cafe.Trainer
{
    partial class Update_Coaching_Class
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblListInstructions = new System.Windows.Forms.Label();
            this.lblSearchInstructions = new System.Windows.Forms.Label();
            this.cboUpdatedDay = new System.Windows.Forms.ComboBox();
            this.lblUpdatedDay = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listSelectedClass = new System.Windows.Forms.ListBox();
            this.datagridCurrentClasses = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblNumberOfClasses = new System.Windows.Forms.Label();
            this.lblFunctionTitle = new System.Windows.Forms.Label();
            this.lblUpdatedVenue = new System.Windows.Forms.Label();
            this.listboxUpdatedVenue = new System.Windows.Forms.ListBox();
            this.cboEndTime = new System.Windows.Forms.ComboBox();
            this.cboStartTime = new System.Windows.Forms.ComboBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.btnSearchVenue = new System.Windows.Forms.Button();
            this.btnViewCurrent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCurrentClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(626, 606);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 55);
            this.btnRefresh.TabIndex = 57;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblInstructions.ForeColor = System.Drawing.Color.White;
            this.lblInstructions.Location = new System.Drawing.Point(810, 562);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(223, 26);
            this.lblInstructions.TabIndex = 56;
            this.lblInstructions.Text = "Fill in the same choices if there is no mistakes.\r\n(Except for venue)\r\n";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClear.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClear.Location = new System.Drawing.Point(767, 606);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 55);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblListInstructions
            // 
            this.lblListInstructions.AutoSize = true;
            this.lblListInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblListInstructions.ForeColor = System.Drawing.Color.White;
            this.lblListInstructions.Location = new System.Drawing.Point(576, 108);
            this.lblListInstructions.Name = "lblListInstructions";
            this.lblListInstructions.Size = new System.Drawing.Size(121, 13);
            this.lblListInstructions.TabIndex = 54;
            this.lblListInstructions.Text = "Select a class to update";
            // 
            // lblSearchInstructions
            // 
            this.lblSearchInstructions.AutoSize = true;
            this.lblSearchInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSearchInstructions.ForeColor = System.Drawing.Color.White;
            this.lblSearchInstructions.Location = new System.Drawing.Point(804, 110);
            this.lblSearchInstructions.Name = "lblSearchInstructions";
            this.lblSearchInstructions.Size = new System.Drawing.Size(256, 13);
            this.lblSearchInstructions.TabIndex = 53;
            this.lblSearchInstructions.Text = "Search for Class Code (search for the first two letters)\r\n";
            // 
            // cboUpdatedDay
            // 
            this.cboUpdatedDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdatedDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboUpdatedDay.FormattingEnabled = true;
            this.cboUpdatedDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday ",
            "Saturday",
            "Sunday"});
            this.cboUpdatedDay.Location = new System.Drawing.Point(814, 206);
            this.cboUpdatedDay.Name = "cboUpdatedDay";
            this.cboUpdatedDay.Size = new System.Drawing.Size(221, 28);
            this.cboUpdatedDay.TabIndex = 52;
            this.cboUpdatedDay.SelectedIndexChanged += new System.EventHandler(this.cboUpdatedDay_SelectedIndexChanged);
            // 
            // lblUpdatedDay
            // 
            this.lblUpdatedDay.AutoSize = true;
            this.lblUpdatedDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUpdatedDay.ForeColor = System.Drawing.Color.White;
            this.lblUpdatedDay.Location = new System.Drawing.Point(809, 180);
            this.lblUpdatedDay.Name = "lblUpdatedDay";
            this.lblUpdatedDay.Size = new System.Drawing.Size(107, 20);
            this.lblUpdatedDay.TabIndex = 48;
            this.lblUpdatedDay.Text = "Updated Day:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSearch.Location = new System.Drawing.Point(990, 157);
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
            this.lblSearch.Location = new System.Drawing.Point(789, 129);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 20);
            this.lblSearch.TabIndex = 43;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(860, 126);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 26);
            this.txtSearch.TabIndex = 42;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // listSelectedClass
            // 
            this.listSelectedClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listSelectedClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listSelectedClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listSelectedClass.ForeColor = System.Drawing.Color.Aquamarine;
            this.listSelectedClass.FormattingEnabled = true;
            this.listSelectedClass.ItemHeight = 20;
            this.listSelectedClass.Location = new System.Drawing.Point(579, 126);
            this.listSelectedClass.Name = "listSelectedClass";
            this.listSelectedClass.Size = new System.Drawing.Size(195, 462);
            this.listSelectedClass.TabIndex = 41;
            this.listSelectedClass.SelectedIndexChanged += new System.EventHandler(this.listSelectedClass_SelectedIndexChanged);
            // 
            // datagridCurrentClasses
            // 
            this.datagridCurrentClasses.AllowUserToAddRows = false;
            this.datagridCurrentClasses.AllowUserToDeleteRows = false;
            this.datagridCurrentClasses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridCurrentClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridCurrentClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCurrentClasses.Location = new System.Drawing.Point(22, 126);
            this.datagridCurrentClasses.MultiSelect = false;
            this.datagridCurrentClasses.Name = "datagridCurrentClasses";
            this.datagridCurrentClasses.ReadOnly = true;
            this.datagridCurrentClasses.RowHeadersWidth = 51;
            this.datagridCurrentClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridCurrentClasses.Size = new System.Drawing.Size(542, 462);
            this.datagridCurrentClasses.TabIndex = 40;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(22, 606);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnUpdate.Location = new System.Drawing.Point(909, 606);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 55);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblNumberOfClasses
            // 
            this.lblNumberOfClasses.AutoSize = true;
            this.lblNumberOfClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNumberOfClasses.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfClasses.Location = new System.Drawing.Point(16, 90);
            this.lblNumberOfClasses.Name = "lblNumberOfClasses";
            this.lblNumberOfClasses.Size = new System.Drawing.Size(223, 31);
            this.lblNumberOfClasses.TabIndex = 37;
            this.lblNumberOfClasses.Text = "View All Classes:";
            // 
            // lblFunctionTitle
            // 
            this.lblFunctionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFunctionTitle.AutoSize = true;
            this.lblFunctionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFunctionTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblFunctionTitle.Location = new System.Drawing.Point(334, 20);
            this.lblFunctionTitle.Name = "lblFunctionTitle";
            this.lblFunctionTitle.Size = new System.Drawing.Size(440, 46);
            this.lblFunctionTitle.TabIndex = 36;
            this.lblFunctionTitle.Text = "Update Coaching Class";
            // 
            // lblUpdatedVenue
            // 
            this.lblUpdatedVenue.AutoSize = true;
            this.lblUpdatedVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUpdatedVenue.ForeColor = System.Drawing.Color.White;
            this.lblUpdatedVenue.Location = new System.Drawing.Point(809, 372);
            this.lblUpdatedVenue.Name = "lblUpdatedVenue";
            this.lblUpdatedVenue.Size = new System.Drawing.Size(126, 20);
            this.lblUpdatedVenue.TabIndex = 58;
            this.lblUpdatedVenue.Text = "Updated Venue:";
            // 
            // listboxUpdatedVenue
            // 
            this.listboxUpdatedVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listboxUpdatedVenue.FormattingEnabled = true;
            this.listboxUpdatedVenue.ItemHeight = 20;
            this.listboxUpdatedVenue.Location = new System.Drawing.Point(813, 394);
            this.listboxUpdatedVenue.Margin = new System.Windows.Forms.Padding(2);
            this.listboxUpdatedVenue.Name = "listboxUpdatedVenue";
            this.listboxUpdatedVenue.Size = new System.Drawing.Size(222, 164);
            this.listboxUpdatedVenue.TabIndex = 60;
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
            this.cboEndTime.Location = new System.Drawing.Point(932, 270);
            this.cboEndTime.Name = "cboEndTime";
            this.cboEndTime.Size = new System.Drawing.Size(103, 28);
            this.cboEndTime.TabIndex = 68;
            this.cboEndTime.SelectedIndexChanged += new System.EventHandler(this.cboEndTime_SelectedIndexChanged);
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
            this.cboStartTime.Location = new System.Drawing.Point(815, 270);
            this.cboStartTime.Name = "cboStartTime";
            this.cboStartTime.Size = new System.Drawing.Size(103, 28);
            this.cboStartTime.TabIndex = 69;
            this.cboStartTime.SelectedIndexChanged += new System.EventHandler(this.cboStartTime_SelectedIndexChanged);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEndTime.ForeColor = System.Drawing.Color.White;
            this.lblEndTime.Location = new System.Drawing.Point(928, 244);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(80, 20);
            this.lblEndTime.TabIndex = 66;
            this.lblEndTime.Text = "End Time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStartTime.ForeColor = System.Drawing.Color.White;
            this.lblStartTime.Location = new System.Drawing.Point(810, 244);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(86, 20);
            this.lblStartTime.TabIndex = 67;
            this.lblStartTime.Text = "Start Time:";
            // 
            // btnSearchVenue
            // 
            this.btnSearchVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSearchVenue.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSearchVenue.Location = new System.Drawing.Point(813, 313);
            this.btnSearchVenue.Name = "btnSearchVenue";
            this.btnSearchVenue.Size = new System.Drawing.Size(222, 47);
            this.btnSearchVenue.TabIndex = 70;
            this.btnSearchVenue.Text = "Search Venue";
            this.btnSearchVenue.UseVisualStyleBackColor = true;
            this.btnSearchVenue.Click += new System.EventHandler(this.btnSearchVenue_Click);
            // 
            // btnViewCurrent
            // 
            this.btnViewCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnViewCurrent.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnViewCurrent.Location = new System.Drawing.Point(342, 594);
            this.btnViewCurrent.Name = "btnViewCurrent";
            this.btnViewCurrent.Size = new System.Drawing.Size(222, 37);
            this.btnViewCurrent.TabIndex = 73;
            this.btnViewCurrent.Text = "View Current Classes";
            this.btnViewCurrent.UseVisualStyleBackColor = true;
            this.btnViewCurrent.Click += new System.EventHandler(this.btnViewCurrent_Click);
            // 
            // Update_Coaching_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnViewCurrent);
            this.Controls.Add(this.btnSearchVenue);
            this.Controls.Add(this.cboEndTime);
            this.Controls.Add(this.cboStartTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.listboxUpdatedVenue);
            this.Controls.Add(this.lblUpdatedVenue);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblListInstructions);
            this.Controls.Add(this.lblSearchInstructions);
            this.Controls.Add(this.cboUpdatedDay);
            this.Controls.Add(this.lblUpdatedDay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listSelectedClass);
            this.Controls.Add(this.datagridCurrentClasses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblNumberOfClasses);
            this.Controls.Add(this.lblFunctionTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Update_Coaching_Class";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.Update_Coaching_Class_Load);
            this.VisibleChanged += new System.EventHandler(this.Update_Coaching_Class_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.datagridCurrentClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblListInstructions;
        private System.Windows.Forms.Label lblSearchInstructions;
        private System.Windows.Forms.ComboBox cboUpdatedDay;
        private System.Windows.Forms.Label lblUpdatedDay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listSelectedClass;
        private System.Windows.Forms.DataGridView datagridCurrentClasses;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblNumberOfClasses;
        private System.Windows.Forms.Label lblFunctionTitle;
        private System.Windows.Forms.Label lblUpdatedVenue;
        private System.Windows.Forms.ListBox listboxUpdatedVenue;
        private System.Windows.Forms.ComboBox cboEndTime;
        private System.Windows.Forms.ComboBox cboStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Button btnSearchVenue;
        private System.Windows.Forms.Button btnViewCurrent;
    }
}
