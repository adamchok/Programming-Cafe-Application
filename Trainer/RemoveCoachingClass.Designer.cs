namespace APU_Programming_Cafe.Trainer
{
    partial class RemoveCoachingClass
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
            this.lblInstructions2 = new System.Windows.Forms.Label();
            this.grpboxFilter = new System.Windows.Forms.GroupBox();
            this.btnFilterSearch = new System.Windows.Forms.Button();
            this.cboFilterIntake = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFilterLevel = new System.Windows.Forms.ComboBox();
            this.cboFilterModule = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblInstruction3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblListInstructions1 = new System.Windows.Forms.Label();
            this.lblSearchInstructions = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listSelectedCoachingClass = new System.Windows.Forms.ListBox();
            this.datagridCoachingClass = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblCoachingClass = new System.Windows.Forms.Label();
            this.lblFunctionTitle = new System.Windows.Forms.Label();
            this.btnClassCompleted = new System.Windows.Forms.Button();
            this.grpboxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCoachingClass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions2
            // 
            this.lblInstructions2.AutoSize = true;
            this.lblInstructions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblInstructions2.ForeColor = System.Drawing.Color.White;
            this.lblInstructions2.Location = new System.Drawing.Point(576, 106);
            this.lblInstructions2.Name = "lblInstructions2";
            this.lblInstructions2.Size = new System.Drawing.Size(105, 13);
            this.lblInstructions2.TabIndex = 77;
            this.lblInstructions2.Text = "Double click to undo\r\n";
            // 
            // grpboxFilter
            // 
            this.grpboxFilter.Controls.Add(this.btnFilterSearch);
            this.grpboxFilter.Controls.Add(this.cboFilterIntake);
            this.grpboxFilter.Controls.Add(this.label1);
            this.grpboxFilter.Controls.Add(this.cboFilterLevel);
            this.grpboxFilter.Controls.Add(this.cboFilterModule);
            this.grpboxFilter.Controls.Add(this.lblDay);
            this.grpboxFilter.Controls.Add(this.lblModule);
            this.grpboxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxFilter.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpboxFilter.Location = new System.Drawing.Point(782, 187);
            this.grpboxFilter.Name = "grpboxFilter";
            this.grpboxFilter.Size = new System.Drawing.Size(279, 397);
            this.grpboxFilter.TabIndex = 76;
            this.grpboxFilter.TabStop = false;
            this.grpboxFilter.Text = "Filter:";
            // 
            // btnFilterSearch
            // 
            this.btnFilterSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnFilterSearch.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnFilterSearch.Location = new System.Drawing.Point(66, 300);
            this.btnFilterSearch.Name = "btnFilterSearch";
            this.btnFilterSearch.Size = new System.Drawing.Size(131, 55);
            this.btnFilterSearch.TabIndex = 78;
            this.btnFilterSearch.Text = "Search";
            this.btnFilterSearch.UseVisualStyleBackColor = true;
            this.btnFilterSearch.Click += new System.EventHandler(this.btnFilterSearch_Click);
            // 
            // cboFilterIntake
            // 
            this.cboFilterIntake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cboFilterIntake.FormattingEnabled = true;
            this.cboFilterIntake.Location = new System.Drawing.Point(33, 221);
            this.cboFilterIntake.Name = "cboFilterIntake";
            this.cboFilterIntake.Size = new System.Drawing.Size(216, 33);
            this.cboFilterIntake.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Intake:";
            // 
            // cboFilterLevel
            // 
            this.cboFilterLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cboFilterLevel.FormattingEnabled = true;
            this.cboFilterLevel.Location = new System.Drawing.Point(32, 148);
            this.cboFilterLevel.Name = "cboFilterLevel";
            this.cboFilterLevel.Size = new System.Drawing.Size(216, 33);
            this.cboFilterLevel.TabIndex = 66;
            // 
            // cboFilterModule
            // 
            this.cboFilterModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cboFilterModule.FormattingEnabled = true;
            this.cboFilterModule.Location = new System.Drawing.Point(33, 69);
            this.cboFilterModule.Name = "cboFilterModule";
            this.cboFilterModule.Size = new System.Drawing.Size(216, 33);
            this.cboFilterModule.TabIndex = 64;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(28, 120);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(70, 25);
            this.lblDay.TabIndex = 63;
            this.lblDay.Text = "Level:";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblModule.ForeColor = System.Drawing.Color.White;
            this.lblModule.Location = new System.Drawing.Point(28, 41);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(89, 25);
            this.lblModule.TabIndex = 61;
            this.lblModule.Text = "Module:";
            // 
            // lblInstruction3
            // 
            this.lblInstruction3.AutoSize = true;
            this.lblInstruction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblInstruction3.ForeColor = System.Drawing.Color.White;
            this.lblInstruction3.Location = new System.Drawing.Point(398, 106);
            this.lblInstruction3.Name = "lblInstruction3";
            this.lblInstruction3.Size = new System.Drawing.Size(166, 13);
            this.lblInstruction3.TabIndex = 75;
            this.lblInstruction3.Text = "Double Click a cell in a row select";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(561, 609);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 55);
            this.btnRefresh.TabIndex = 74;
            this.btnRefresh.Text = "Refresh Table";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClear.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClear.Location = new System.Drawing.Point(770, 609);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 55);
            this.btnClear.TabIndex = 73;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblListInstructions1
            // 
            this.lblListInstructions1.AutoSize = true;
            this.lblListInstructions1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblListInstructions1.ForeColor = System.Drawing.Color.White;
            this.lblListInstructions1.Location = new System.Drawing.Point(576, 92);
            this.lblListInstructions1.Name = "lblListInstructions1";
            this.lblListInstructions1.Size = new System.Drawing.Size(202, 13);
            this.lblListInstructions1.TabIndex = 72;
            this.lblListInstructions1.Text = "List of Coaching Classes To be Removed";
            // 
            // lblSearchInstructions
            // 
            this.lblSearchInstructions.AutoSize = true;
            this.lblSearchInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSearchInstructions.ForeColor = System.Drawing.Color.White;
            this.lblSearchInstructions.Location = new System.Drawing.Point(844, 109);
            this.lblSearchInstructions.Name = "lblSearchInstructions";
            this.lblSearchInstructions.Size = new System.Drawing.Size(112, 13);
            this.lblSearchInstructions.TabIndex = 71;
            this.lblSearchInstructions.Text = "Search for Class Code";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSearch.Location = new System.Drawing.Point(992, 157);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 28);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(777, 128);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 20);
            this.lblSearch.TabIndex = 69;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(848, 125);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(213, 26);
            this.txtSearch.TabIndex = 68;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // listSelectedCoachingClass
            // 
            this.listSelectedCoachingClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listSelectedCoachingClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listSelectedCoachingClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listSelectedCoachingClass.ForeColor = System.Drawing.Color.Aquamarine;
            this.listSelectedCoachingClass.FormattingEnabled = true;
            this.listSelectedCoachingClass.ItemHeight = 20;
            this.listSelectedCoachingClass.Location = new System.Drawing.Point(579, 128);
            this.listSelectedCoachingClass.Name = "listSelectedCoachingClass";
            this.listSelectedCoachingClass.Size = new System.Drawing.Size(192, 402);
            this.listSelectedCoachingClass.TabIndex = 67;
            this.listSelectedCoachingClass.DoubleClick += new System.EventHandler(this.listSelectedCoachingClass_DoubleClick);
            // 
            // datagridCoachingClass
            // 
            this.datagridCoachingClass.AllowUserToAddRows = false;
            this.datagridCoachingClass.AllowUserToDeleteRows = false;
            this.datagridCoachingClass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridCoachingClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridCoachingClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCoachingClass.Location = new System.Drawing.Point(22, 122);
            this.datagridCoachingClass.MultiSelect = false;
            this.datagridCoachingClass.Name = "datagridCoachingClass";
            this.datagridCoachingClass.ReadOnly = true;
            this.datagridCoachingClass.RowHeadersWidth = 51;
            this.datagridCoachingClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridCoachingClass.Size = new System.Drawing.Size(542, 462);
            this.datagridCoachingClass.TabIndex = 66;
            this.datagridCoachingClass.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridCoachingClass_CellDoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(22, 609);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 65;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRemove.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRemove.Location = new System.Drawing.Point(908, 609);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(131, 55);
            this.btnRemove.TabIndex = 64;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblCoachingClass
            // 
            this.lblCoachingClass.AutoSize = true;
            this.lblCoachingClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCoachingClass.ForeColor = System.Drawing.Color.White;
            this.lblCoachingClass.Location = new System.Drawing.Point(16, 77);
            this.lblCoachingClass.Name = "lblCoachingClass";
            this.lblCoachingClass.Size = new System.Drawing.Size(311, 31);
            this.lblCoachingClass.TabIndex = 63;
            this.lblCoachingClass.Text = "Current Coaching Class:";
            // 
            // lblFunctionTitle
            // 
            this.lblFunctionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFunctionTitle.AutoSize = true;
            this.lblFunctionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFunctionTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblFunctionTitle.Location = new System.Drawing.Point(330, 17);
            this.lblFunctionTitle.Name = "lblFunctionTitle";
            this.lblFunctionTitle.Size = new System.Drawing.Size(460, 46);
            this.lblFunctionTitle.TabIndex = 62;
            this.lblFunctionTitle.Text = "Remove Coaching Class";
            // 
            // btnClassCompleted
            // 
            this.btnClassCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClassCompleted.ForeColor = System.Drawing.Color.Tomato;
            this.btnClassCompleted.Location = new System.Drawing.Point(579, 535);
            this.btnClassCompleted.Name = "btnClassCompleted";
            this.btnClassCompleted.Size = new System.Drawing.Size(192, 49);
            this.btnClassCompleted.TabIndex = 79;
            this.btnClassCompleted.Text = "Class Completed";
            this.btnClassCompleted.UseVisualStyleBackColor = true;
            this.btnClassCompleted.Click += new System.EventHandler(this.btnClassCompleted_Click);
            // 
            // RemoveCoachingClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnClassCompleted);
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
            this.Controls.Add(this.listSelectedCoachingClass);
            this.Controls.Add(this.datagridCoachingClass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblCoachingClass);
            this.Controls.Add(this.lblFunctionTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RemoveCoachingClass";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.RemoveCoachingClass_Load);
            this.VisibleChanged += new System.EventHandler(this.RemoveCoachingClass_VisibleChanged);
            this.grpboxFilter.ResumeLayout(false);
            this.grpboxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCoachingClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions2;
        private System.Windows.Forms.GroupBox grpboxFilter;
        private System.Windows.Forms.Label lblInstruction3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblListInstructions1;
        private System.Windows.Forms.Label lblSearchInstructions;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listSelectedCoachingClass;
        private System.Windows.Forms.DataGridView datagridCoachingClass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblCoachingClass;
        private System.Windows.Forms.Label lblFunctionTitle;
        private System.Windows.Forms.ComboBox cboFilterLevel;
        private System.Windows.Forms.ComboBox cboFilterModule;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.ComboBox cboFilterIntake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterSearch;
        private System.Windows.Forms.Button btnClassCompleted;
    }
}
