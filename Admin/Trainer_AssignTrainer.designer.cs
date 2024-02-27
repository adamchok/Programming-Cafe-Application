namespace APU_Programming_Cafe.Admin
{
    partial class Trainer_AssignTrainer
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblTrainerID = new System.Windows.Forms.Label();
            this.grpLevel = new System.Windows.Forms.GroupBox();
            this.rbtnAdvanced = new System.Windows.Forms.RadioButton();
            this.rbtnIntermediate = new System.Windows.Forms.RadioButton();
            this.rbtnBeginner = new System.Windows.Forms.RadioButton();
            this.cboModule = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.cboTrainerName = new System.Windows.Forms.ComboBox();
            this.grpLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFunctionTitle
            // 
            this.lblFunctionTitle.AutoSize = true;
            this.lblFunctionTitle.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunctionTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblFunctionTitle.Location = new System.Drawing.Point(340, 32);
            this.lblFunctionTitle.Name = "lblFunctionTitle";
            this.lblFunctionTitle.Size = new System.Drawing.Size(399, 43);
            this.lblFunctionTitle.TabIndex = 0;
            this.lblFunctionTitle.Text = "ASSIGN TRAINER FORM";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(184, 138);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(194, 31);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Trainer Name :";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModule.ForeColor = System.Drawing.Color.White;
            this.lblModule.Location = new System.Drawing.Point(256, 507);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(117, 31);
            this.lblModule.TabIndex = 3;
            this.lblModule.Text = "Module :";
            // 
            // lblTrainerID
            // 
            this.lblTrainerID.AutoSize = true;
            this.lblTrainerID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblTrainerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTrainerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerID.ForeColor = System.Drawing.Color.Black;
            this.lblTrainerID.Location = new System.Drawing.Point(396, 201);
            this.lblTrainerID.MinimumSize = new System.Drawing.Size(500, 0);
            this.lblTrainerID.Name = "lblTrainerID";
            this.lblTrainerID.Size = new System.Drawing.Size(500, 31);
            this.lblTrainerID.TabIndex = 4;
            // 
            // grpLevel
            // 
            this.grpLevel.Controls.Add(this.rbtnAdvanced);
            this.grpLevel.Controls.Add(this.rbtnIntermediate);
            this.grpLevel.Controls.Add(this.rbtnBeginner);
            this.grpLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLevel.ForeColor = System.Drawing.Color.White;
            this.grpLevel.Location = new System.Drawing.Point(185, 260);
            this.grpLevel.Name = "grpLevel";
            this.grpLevel.Size = new System.Drawing.Size(713, 203);
            this.grpLevel.TabIndex = 6;
            this.grpLevel.TabStop = false;
            this.grpLevel.Text = "Level";
            // 
            // rbtnAdvanced
            // 
            this.rbtnAdvanced.AutoSize = true;
            this.rbtnAdvanced.Location = new System.Drawing.Point(211, 138);
            this.rbtnAdvanced.Name = "rbtnAdvanced";
            this.rbtnAdvanced.Size = new System.Drawing.Size(153, 35);
            this.rbtnAdvanced.TabIndex = 0;
            this.rbtnAdvanced.TabStop = true;
            this.rbtnAdvanced.Text = "Advanced";
            this.rbtnAdvanced.UseVisualStyleBackColor = true;
            // 
            // rbtnIntermediate
            // 
            this.rbtnIntermediate.AutoSize = true;
            this.rbtnIntermediate.Location = new System.Drawing.Point(213, 88);
            this.rbtnIntermediate.Name = "rbtnIntermediate";
            this.rbtnIntermediate.Size = new System.Drawing.Size(183, 35);
            this.rbtnIntermediate.TabIndex = 0;
            this.rbtnIntermediate.TabStop = true;
            this.rbtnIntermediate.Text = "Intermediate";
            this.rbtnIntermediate.UseVisualStyleBackColor = true;
            // 
            // rbtnBeginner
            // 
            this.rbtnBeginner.AutoSize = true;
            this.rbtnBeginner.Location = new System.Drawing.Point(211, 42);
            this.rbtnBeginner.Name = "rbtnBeginner";
            this.rbtnBeginner.Size = new System.Drawing.Size(140, 35);
            this.rbtnBeginner.TabIndex = 0;
            this.rbtnBeginner.TabStop = true;
            this.rbtnBeginner.Text = "Beginner";
            this.rbtnBeginner.UseVisualStyleBackColor = true;
            // 
            // cboModule
            // 
            this.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Items.AddRange(new object[] {
            "C#",
            "HTML",
            "Java",
            "Python"});
            this.cboModule.Location = new System.Drawing.Point(399, 504);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(499, 39);
            this.cboModule.TabIndex = 7;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(226, 198);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(150, 31);
            this.lblID.TabIndex = 32;
            this.lblID.Text = "Trainer ID :";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClear.Location = new System.Drawing.Point(493, 591);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 57);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(690, 591);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 57);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnAssign.Location = new System.Drawing.Point(886, 591);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(173, 57);
            this.btnAssign.TabIndex = 41;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // cboTrainerName
            // 
            this.cboTrainerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrainerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrainerName.FormattingEnabled = true;
            this.cboTrainerName.Location = new System.Drawing.Point(396, 136);
            this.cboTrainerName.Name = "cboTrainerName";
            this.cboTrainerName.Size = new System.Drawing.Size(500, 39);
            this.cboTrainerName.TabIndex = 44;
            this.cboTrainerName.SelectedIndexChanged += new System.EventHandler(this.cboTrainerName_SelectedIndexChanged);
            // 
            // Trainer_AssignTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.cboTrainerName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cboModule);
            this.Controls.Add(this.grpLevel);
            this.Controls.Add(this.lblTrainerID);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFunctionTitle);
            this.Name = "Trainer_AssignTrainer";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.Trainer_AssignTrainer_Load);
            this.VisibleChanged += new System.EventHandler(this.Trainer_AssignTrainer_VisibleChanged);
            this.grpLevel.ResumeLayout(false);
            this.grpLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFunctionTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblTrainerID;
        private System.Windows.Forms.GroupBox grpLevel;
        private System.Windows.Forms.RadioButton rbtnAdvanced;
        private System.Windows.Forms.RadioButton rbtnIntermediate;
        private System.Windows.Forms.RadioButton rbtnBeginner;
        private System.Windows.Forms.ComboBox cboModule;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ComboBox cboTrainerName;
    }
}
