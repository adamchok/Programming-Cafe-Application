namespace APU_Programming_Cafe.Admin
{
    partial class ViewIncomeReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.datagridIncomeReport = new System.Windows.Forms.DataGridView();
            this.grpboxIncomeReport = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTrainerID = new System.Windows.Forms.Button();
            this.btnLevel = new System.Windows.Forms.Button();
            this.btnModule = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridIncomeReport)).BeginInit();
            this.grpboxIncomeReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(556, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "INCOME REPORT";
            // 
            // datagridIncomeReport
            // 
            this.datagridIncomeReport.AllowUserToAddRows = false;
            this.datagridIncomeReport.AllowUserToDeleteRows = false;
            this.datagridIncomeReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridIncomeReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridIncomeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridIncomeReport.Location = new System.Drawing.Point(350, 64);
            this.datagridIncomeReport.MultiSelect = false;
            this.datagridIncomeReport.Name = "datagridIncomeReport";
            this.datagridIncomeReport.ReadOnly = true;
            this.datagridIncomeReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridIncomeReport.Size = new System.Drawing.Size(709, 527);
            this.datagridIncomeReport.TabIndex = 4;
            // 
            // grpboxIncomeReport
            // 
            this.grpboxIncomeReport.Controls.Add(this.cboYear);
            this.grpboxIncomeReport.Controls.Add(this.lblYear);
            this.grpboxIncomeReport.Controls.Add(this.btnModule);
            this.grpboxIncomeReport.Controls.Add(this.btnLevel);
            this.grpboxIncomeReport.Controls.Add(this.btnTrainerID);
            this.grpboxIncomeReport.Controls.Add(this.btnClear);
            this.grpboxIncomeReport.Controls.Add(this.cboMonth);
            this.grpboxIncomeReport.Controls.Add(this.lblMonth);
            this.grpboxIncomeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxIncomeReport.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpboxIncomeReport.Location = new System.Drawing.Point(12, 18);
            this.grpboxIncomeReport.Name = "grpboxIncomeReport";
            this.grpboxIncomeReport.Size = new System.Drawing.Size(322, 647);
            this.grpboxIncomeReport.TabIndex = 70;
            this.grpboxIncomeReport.TabStop = false;
            this.grpboxIncomeReport.Text = "View Income Report Based On:";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClear.Location = new System.Drawing.Point(24, 553);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(277, 53);
            this.btnClear.TabIndex = 73;
            this.btnClear.Text = "Clear Month and Year";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cboMonth.Location = new System.Drawing.Point(24, 123);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(277, 33);
            this.cboMonth.TabIndex = 72;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(18, 80);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(97, 31);
            this.lblMonth.TabIndex = 71;
            this.lblMonth.Text = "Month:";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(886, 608);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 57);
            this.btnExit.TabIndex = 71;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTrainerID
            // 
            this.btnTrainerID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainerID.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnTrainerID.Location = new System.Drawing.Point(24, 276);
            this.btnTrainerID.Name = "btnTrainerID";
            this.btnTrainerID.Size = new System.Drawing.Size(277, 53);
            this.btnTrainerID.TabIndex = 75;
            this.btnTrainerID.Text = "TrainerID";
            this.btnTrainerID.UseVisualStyleBackColor = true;
            this.btnTrainerID.Click += new System.EventHandler(this.btnTrainerID_Click);
            // 
            // btnLevel
            // 
            this.btnLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnLevel.Location = new System.Drawing.Point(24, 354);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(277, 53);
            this.btnLevel.TabIndex = 76;
            this.btnLevel.Text = "Level";
            this.btnLevel.UseVisualStyleBackColor = true;
            this.btnLevel.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnModule
            // 
            this.btnModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModule.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnModule.Location = new System.Drawing.Point(24, 432);
            this.btnModule.Name = "btnModule";
            this.btnModule.Size = new System.Drawing.Size(277, 53);
            this.btnModule.TabIndex = 77;
            this.btnModule.Text = "Module";
            this.btnModule.UseVisualStyleBackColor = true;
            this.btnModule.Click += new System.EventHandler(this.btnModule_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnReset.Location = new System.Drawing.Point(694, 608);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(173, 57);
            this.btnReset.TabIndex = 72;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cboYear.Location = new System.Drawing.Point(24, 213);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(277, 33);
            this.cboYear.TabIndex = 79;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(18, 170);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(79, 31);
            this.lblYear.TabIndex = 78;
            this.lblYear.Text = "Year:";
            // 
            // ViewIncomeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpboxIncomeReport);
            this.Controls.Add(this.datagridIncomeReport);
            this.Controls.Add(this.label1);
            this.Name = "ViewIncomeReport";
            this.Size = new System.Drawing.Size(1078, 681);
            this.VisibleChanged += new System.EventHandler(this.ViewIncomeReport_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.datagridIncomeReport)).EndInit();
            this.grpboxIncomeReport.ResumeLayout(false);
            this.grpboxIncomeReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridIncomeReport;
        private System.Windows.Forms.GroupBox grpboxIncomeReport;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnModule;
        private System.Windows.Forms.Button btnLevel;
        private System.Windows.Forms.Button btnTrainerID;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblYear;
    }
}
