namespace APU_Programming_Cafe.Student
{
    partial class frmRequest
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
            this.lblForm2Title = new System.Windows.Forms.Label();
            this.grpboxFilterClass = new System.Windows.Forms.GroupBox();
            this.lblLevelFilter = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblModuleFilter = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.cboModule = new System.Windows.Forms.ComboBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.datagridClasses = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblClasses = new System.Windows.Forms.Label();
            this.grpboxFilterClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForm2Title
            // 
            this.lblForm2Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblForm2Title.AutoSize = true;
            this.lblForm2Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblForm2Title.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblForm2Title.Location = new System.Drawing.Point(370, 27);
            this.lblForm2Title.Name = "lblForm2Title";
            this.lblForm2Title.Size = new System.Drawing.Size(343, 46);
            this.lblForm2Title.TabIndex = 1;
            this.lblForm2Title.Text = "Request a module";
            // 
            // grpboxFilterClass
            // 
            this.grpboxFilterClass.Controls.Add(this.lblLevelFilter);
            this.grpboxFilterClass.Controls.Add(this.btnClear);
            this.grpboxFilterClass.Controls.Add(this.lblModuleFilter);
            this.grpboxFilterClass.Controls.Add(this.cboLevel);
            this.grpboxFilterClass.Controls.Add(this.cboModule);
            this.grpboxFilterClass.Controls.Add(this.btnRequest);
            this.grpboxFilterClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxFilterClass.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpboxFilterClass.Location = new System.Drawing.Point(662, 122);
            this.grpboxFilterClass.Name = "grpboxFilterClass";
            this.grpboxFilterClass.Size = new System.Drawing.Size(378, 348);
            this.grpboxFilterClass.TabIndex = 76;
            this.grpboxFilterClass.TabStop = false;
            this.grpboxFilterClass.Text = "Pick a class:";
            // 
            // lblLevelFilter
            // 
            this.lblLevelFilter.AutoSize = true;
            this.lblLevelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelFilter.ForeColor = System.Drawing.Color.White;
            this.lblLevelFilter.Location = new System.Drawing.Point(41, 36);
            this.lblLevelFilter.Name = "lblLevelFilter";
            this.lblLevelFilter.Size = new System.Drawing.Size(77, 29);
            this.lblLevelFilter.TabIndex = 45;
            this.lblLevelFilter.Text = "Level:";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClear.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClear.Location = new System.Drawing.Point(45, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 55);
            this.btnClear.TabIndex = 73;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblModuleFilter
            // 
            this.lblModuleFilter.AutoSize = true;
            this.lblModuleFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleFilter.ForeColor = System.Drawing.Color.White;
            this.lblModuleFilter.Location = new System.Drawing.Point(41, 125);
            this.lblModuleFilter.Name = "lblModuleFilter";
            this.lblModuleFilter.Size = new System.Drawing.Size(100, 29);
            this.lblModuleFilter.TabIndex = 46;
            this.lblModuleFilter.Text = "Module:";
            // 
            // cboLevel
            // 
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cboLevel.Location = new System.Drawing.Point(45, 68);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(297, 37);
            this.cboLevel.TabIndex = 49;
            // 
            // cboModule
            // 
            this.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Items.AddRange(new object[] {
            "Python",
            "HTML",
            "Java",
            "C#"});
            this.cboModule.Location = new System.Drawing.Point(45, 157);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(297, 37);
            this.cboModule.TabIndex = 50;
            // 
            // btnRequest
            // 
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRequest.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRequest.Location = new System.Drawing.Point(211, 262);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(131, 55);
            this.btnRequest.TabIndex = 64;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // datagridClasses
            // 
            this.datagridClasses.AllowUserToAddRows = false;
            this.datagridClasses.AllowUserToDeleteRows = false;
            this.datagridClasses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridClasses.Location = new System.Drawing.Point(85, 122);
            this.datagridClasses.MultiSelect = false;
            this.datagridClasses.Name = "datagridClasses";
            this.datagridClasses.ReadOnly = true;
            this.datagridClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridClasses.Size = new System.Drawing.Size(542, 462);
            this.datagridClasses.TabIndex = 66;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(23, 602);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 65;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblClasses.ForeColor = System.Drawing.Color.White;
            this.lblClasses.Location = new System.Drawing.Point(79, 77);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(238, 31);
            this.lblClasses.TabIndex = 63;
            this.lblClasses.Text = "Modules available:";
            // 
            // frmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.grpboxFilterClass);
            this.Controls.Add(this.datagridClasses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.lblForm2Title);
            this.Name = "frmRequest";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.frmRequest_Load);
            this.VisibleChanged += new System.EventHandler(this.frmRequest_VisibleChanged);
            this.grpboxFilterClass.ResumeLayout(false);
            this.grpboxFilterClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForm2Title;
        private System.Windows.Forms.GroupBox grpboxFilterClass;
        private System.Windows.Forms.Label lblLevelFilter;
        private System.Windows.Forms.Label lblModuleFilter;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.ComboBox cboModule;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView datagridClasses;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label lblClasses;
    }
}
