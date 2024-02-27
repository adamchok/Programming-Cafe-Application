namespace APU_Programming_Cafe.Admin
{
    partial class ValidatePaymentAndAssign
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
            this.lblTitleFunction = new System.Windows.Forms.Label();
            this.datagridTrainerList = new System.Windows.Forms.DataGridView();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.grpboxAssign = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblModuleCode = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.cboTrainerID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIntake = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTrainerList)).BeginInit();
            this.grpboxAssign.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleFunction
            // 
            this.lblTitleFunction.AutoSize = true;
            this.lblTitleFunction.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFunction.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblTitleFunction.Location = new System.Drawing.Point(34, 17);
            this.lblTitleFunction.Name = "lblTitleFunction";
            this.lblTitleFunction.Size = new System.Drawing.Size(1019, 43);
            this.lblTitleFunction.TabIndex = 2;
            this.lblTitleFunction.Text = "VALIDATE PAYMENT AND ASSIGNING STUDENTS TO TRAINER";
            // 
            // datagridTrainerList
            // 
            this.datagridTrainerList.AllowUserToAddRows = false;
            this.datagridTrainerList.AllowUserToDeleteRows = false;
            this.datagridTrainerList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridTrainerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridTrainerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTrainerList.Location = new System.Drawing.Point(14, 116);
            this.datagridTrainerList.MultiSelect = false;
            this.datagridTrainerList.Name = "datagridTrainerList";
            this.datagridTrainerList.ReadOnly = true;
            this.datagridTrainerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridTrainerList.Size = new System.Drawing.Size(799, 447);
            this.datagridTrainerList.TabIndex = 3;
            this.datagridTrainerList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridTrainerList_CellDoubleClick);
            // 
            // lblStudentID
            // 
            this.lblStudentID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblStudentID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblStudentID.ForeColor = System.Drawing.Color.Black;
            this.lblStudentID.Location = new System.Drawing.Point(19, 65);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(200, 28);
            this.lblStudentID.TabIndex = 6;
            // 
            // grpboxAssign
            // 
            this.grpboxAssign.Controls.Add(this.label4);
            this.grpboxAssign.Controls.Add(this.lblIntake);
            this.grpboxAssign.Controls.Add(this.label9);
            this.grpboxAssign.Controls.Add(this.lblModuleCode);
            this.grpboxAssign.Controls.Add(this.btnAssign);
            this.grpboxAssign.Controls.Add(this.cboTrainerID);
            this.grpboxAssign.Controls.Add(this.label3);
            this.grpboxAssign.Controls.Add(this.lblStudentName);
            this.grpboxAssign.Controls.Add(this.label2);
            this.grpboxAssign.Controls.Add(this.label1);
            this.grpboxAssign.Controls.Add(this.lblStudentID);
            this.grpboxAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxAssign.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpboxAssign.Location = new System.Drawing.Point(819, 108);
            this.grpboxAssign.Name = "grpboxAssign";
            this.grpboxAssign.Size = new System.Drawing.Size(234, 455);
            this.grpboxAssign.TabIndex = 69;
            this.grpboxAssign.TabStop = false;
            this.grpboxAssign.Text = "Assign Trainer:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 26);
            this.label9.TabIndex = 72;
            this.label9.Text = "ModuleCode:";
            // 
            // lblModuleCode
            // 
            this.lblModuleCode.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblModuleCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModuleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblModuleCode.ForeColor = System.Drawing.Color.Black;
            this.lblModuleCode.Location = new System.Drawing.Point(19, 200);
            this.lblModuleCode.Name = "lblModuleCode";
            this.lblModuleCode.Size = new System.Drawing.Size(200, 28);
            this.lblModuleCode.TabIndex = 71;
            // 
            // btnAssign
            // 
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAssign.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnAssign.Location = new System.Drawing.Point(19, 381);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(200, 60);
            this.btnAssign.TabIndex = 70;
            this.btnAssign.Text = "Assign and Validate";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // cboTrainerID
            // 
            this.cboTrainerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrainerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboTrainerID.FormattingEnabled = true;
            this.cboTrainerID.Location = new System.Drawing.Point(19, 335);
            this.cboTrainerID.Name = "cboTrainerID";
            this.cboTrainerID.Size = new System.Drawing.Size(200, 32);
            this.cboTrainerID.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "TrainerID:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblStudentName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblStudentName.ForeColor = System.Drawing.Color.Black;
            this.lblStudentName.Location = new System.Drawing.Point(19, 132);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(200, 28);
            this.lblStudentName.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Student ID:";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(880, 591);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 57);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(14, 591);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(173, 57);
            this.btnRefresh.TabIndex = 73;
            this.btnRefresh.Text = "Refresh Table";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(517, 31);
            this.label7.TabIndex = 74;
            this.label7.Text = "List of Student Who Have Made Payment:";
            // 
            // btnReject
            // 
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnReject.Location = new System.Drawing.Point(643, 592);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(198, 57);
            this.btnReject.TabIndex = 73;
            this.btnReject.Text = "Reject Payment";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 74;
            this.label4.Text = "Intake:";
            // 
            // lblIntake
            // 
            this.lblIntake.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblIntake.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblIntake.ForeColor = System.Drawing.Color.Black;
            this.lblIntake.Location = new System.Drawing.Point(19, 267);
            this.lblIntake.Name = "lblIntake";
            this.lblIntake.Size = new System.Drawing.Size(200, 28);
            this.lblIntake.TabIndex = 73;
            // 
            // ValidatePaymentAndAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpboxAssign);
            this.Controls.Add(this.datagridTrainerList);
            this.Controls.Add(this.lblTitleFunction);
            this.Name = "ValidatePaymentAndAssign";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.ValidatePaymentAndAssign_Load);
            this.VisibleChanged += new System.EventHandler(this.ValidatePaymentAndAssign_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.datagridTrainerList)).EndInit();
            this.grpboxAssign.ResumeLayout(false);
            this.grpboxAssign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleFunction;
        private System.Windows.Forms.DataGridView datagridTrainerList;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.GroupBox grpboxAssign;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTrainerID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblModuleCode;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIntake;
    }
}
