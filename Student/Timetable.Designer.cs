namespace APU_Programming_Cafe.Student
{
    partial class Timetable
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
            this.lblTimetableTitle = new System.Windows.Forms.Label();
            this.grpboxTimetable = new System.Windows.Forms.GroupBox();
            this.cboIntake = new System.Windows.Forms.ComboBox();
            this.cboModule = new System.Windows.Forms.ComboBox();
            this.lblIntake = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.datagridScheduleStudent = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpboxTimetable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridScheduleStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimetableTitle
            // 
            this.lblTimetableTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTimetableTitle.AutoSize = true;
            this.lblTimetableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTimetableTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblTimetableTitle.Location = new System.Drawing.Point(418, 31);
            this.lblTimetableTitle.Name = "lblTimetableTitle";
            this.lblTimetableTitle.Size = new System.Drawing.Size(194, 46);
            this.lblTimetableTitle.TabIndex = 3;
            this.lblTimetableTitle.Text = "Timetable";
            // 
            // grpboxTimetable
            // 
            this.grpboxTimetable.Controls.Add(this.cboIntake);
            this.grpboxTimetable.Controls.Add(this.cboModule);
            this.grpboxTimetable.Controls.Add(this.lblIntake);
            this.grpboxTimetable.Controls.Add(this.lblModule);
            this.grpboxTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxTimetable.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpboxTimetable.Location = new System.Drawing.Point(173, 80);
            this.grpboxTimetable.Name = "grpboxTimetable";
            this.grpboxTimetable.Size = new System.Drawing.Size(684, 160);
            this.grpboxTimetable.TabIndex = 62;
            this.grpboxTimetable.TabStop = false;
            this.grpboxTimetable.Text = "My Timetable:";
            // 
            // cboIntake
            // 
            this.cboIntake.AllowDrop = true;
            this.cboIntake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboIntake.FormattingEnabled = true;
            this.cboIntake.Location = new System.Drawing.Point(366, 82);
            this.cboIntake.Name = "cboIntake";
            this.cboIntake.Size = new System.Drawing.Size(249, 28);
            this.cboIntake.TabIndex = 65;
            // 
            // cboModule
            // 
            this.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Location = new System.Drawing.Point(63, 82);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(249, 28);
            this.cboModule.TabIndex = 64;
            // 
            // lblIntake
            // 
            this.lblIntake.AutoSize = true;
            this.lblIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIntake.ForeColor = System.Drawing.Color.White;
            this.lblIntake.Location = new System.Drawing.Point(361, 56);
            this.lblIntake.Name = "lblIntake";
            this.lblIntake.Size = new System.Drawing.Size(58, 20);
            this.lblIntake.TabIndex = 62;
            this.lblIntake.Text = "Intake:";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblModule.ForeColor = System.Drawing.Color.White;
            this.lblModule.Location = new System.Drawing.Point(58, 56);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(65, 20);
            this.lblModule.TabIndex = 61;
            this.lblModule.Text = "Module:";
            // 
            // btnApply
            // 
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnApply.Location = new System.Drawing.Point(459, 220);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(104, 41);
            this.btnApply.TabIndex = 59;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // datagridScheduleStudent
            // 
            this.datagridScheduleStudent.AllowUserToAddRows = false;
            this.datagridScheduleStudent.AllowUserToDeleteRows = false;
            this.datagridScheduleStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridScheduleStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridScheduleStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridScheduleStudent.Location = new System.Drawing.Point(48, 268);
            this.datagridScheduleStudent.MultiSelect = false;
            this.datagridScheduleStudent.Name = "datagridScheduleStudent";
            this.datagridScheduleStudent.ReadOnly = true;
            this.datagridScheduleStudent.RowHeadersWidth = 51;
            this.datagridScheduleStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridScheduleStudent.Size = new System.Drawing.Size(963, 327);
            this.datagridScheduleStudent.TabIndex = 64;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(48, 610);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 65;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(199, 610);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 55);
            this.btnRefresh.TabIndex = 66;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.datagridScheduleStudent);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpboxTimetable);
            this.Controls.Add(this.lblTimetableTitle);
            this.Name = "Timetable";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.Timetable_Load);
            this.VisibleChanged += new System.EventHandler(this.Timetable_VisibleChanged);
            this.grpboxTimetable.ResumeLayout(false);
            this.grpboxTimetable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridScheduleStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTimetableTitle;
        private System.Windows.Forms.GroupBox grpboxTimetable;
        private System.Windows.Forms.ComboBox cboIntake;
        private System.Windows.Forms.ComboBox cboModule;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblIntake;
        private System.Windows.Forms.DataGridView datagridScheduleStudent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
    }
}
