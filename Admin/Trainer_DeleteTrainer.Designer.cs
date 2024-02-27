namespace APU_Programming_Cafe.Admin
{
    partial class Trainer_DeleteTrainer
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
            this.datagridTrainerList = new System.Windows.Forms.DataGridView();
            this.lblTrainerList = new System.Windows.Forms.Label();
            this.lblStatement1 = new System.Windows.Forms.Label();
            this.listSelectedTrainers = new System.Windows.Forms.ListBox();
            this.lblStatement2 = new System.Windows.Forms.Label();
            this.lblStatement3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTrainerList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFunctionTitle
            // 
            this.lblFunctionTitle.AutoSize = true;
            this.lblFunctionTitle.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunctionTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblFunctionTitle.Location = new System.Drawing.Point(340, 31);
            this.lblFunctionTitle.Name = "lblFunctionTitle";
            this.lblFunctionTitle.Size = new System.Drawing.Size(399, 43);
            this.lblFunctionTitle.TabIndex = 1;
            this.lblFunctionTitle.Text = "DELETE TRAINER FORM";
            // 
            // datagridTrainerList
            // 
            this.datagridTrainerList.AllowUserToAddRows = false;
            this.datagridTrainerList.AllowUserToDeleteRows = false;
            this.datagridTrainerList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridTrainerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridTrainerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTrainerList.Location = new System.Drawing.Point(35, 153);
            this.datagridTrainerList.MultiSelect = false;
            this.datagridTrainerList.Name = "datagridTrainerList";
            this.datagridTrainerList.ReadOnly = true;
            this.datagridTrainerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridTrainerList.Size = new System.Drawing.Size(692, 404);
            this.datagridTrainerList.TabIndex = 2;
            this.datagridTrainerList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridTrainerList_CellContentDoubleClick);
            // 
            // lblTrainerList
            // 
            this.lblTrainerList.AutoSize = true;
            this.lblTrainerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerList.ForeColor = System.Drawing.Color.White;
            this.lblTrainerList.Location = new System.Drawing.Point(29, 112);
            this.lblTrainerList.Name = "lblTrainerList";
            this.lblTrainerList.Size = new System.Drawing.Size(188, 31);
            this.lblTrainerList.TabIndex = 33;
            this.lblTrainerList.Text = "List of Trainer:";
            // 
            // lblStatement1
            // 
            this.lblStatement1.AutoSize = true;
            this.lblStatement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement1.ForeColor = System.Drawing.Color.White;
            this.lblStatement1.Location = new System.Drawing.Point(223, 127);
            this.lblStatement1.Name = "lblStatement1";
            this.lblStatement1.Size = new System.Drawing.Size(184, 13);
            this.lblStatement1.TabIndex = 34;
            this.lblStatement1.Text = "Double Click a Row of Data to Select";
            // 
            // listSelectedTrainers
            // 
            this.listSelectedTrainers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listSelectedTrainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSelectedTrainers.ForeColor = System.Drawing.Color.White;
            this.listSelectedTrainers.FormattingEnabled = true;
            this.listSelectedTrainers.ItemHeight = 20;
            this.listSelectedTrainers.Location = new System.Drawing.Point(744, 153);
            this.listSelectedTrainers.Name = "listSelectedTrainers";
            this.listSelectedTrainers.Size = new System.Drawing.Size(211, 404);
            this.listSelectedTrainers.TabIndex = 35;
            this.listSelectedTrainers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSelectedTrainers_MouseDoubleClick);
            // 
            // lblStatement2
            // 
            this.lblStatement2.AutoSize = true;
            this.lblStatement2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement2.ForeColor = System.Drawing.Color.White;
            this.lblStatement2.Location = new System.Drawing.Point(741, 109);
            this.lblStatement2.Name = "lblStatement2";
            this.lblStatement2.Size = new System.Drawing.Size(195, 13);
            this.lblStatement2.TabIndex = 36;
            this.lblStatement2.Text = "Double Click to remove Trainer from List";
            // 
            // lblStatement3
            // 
            this.lblStatement3.AutoSize = true;
            this.lblStatement3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement3.ForeColor = System.Drawing.Color.White;
            this.lblStatement3.Location = new System.Drawing.Point(741, 127);
            this.lblStatement3.Name = "lblStatement3";
            this.lblStatement3.Size = new System.Drawing.Size(145, 13);
            this.lblStatement3.TabIndex = 37;
            this.lblStatement3.Text = "List of Trainer to be removed:";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClear.Location = new System.Drawing.Point(689, 583);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 57);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(23, 583);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 57);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRemove.Location = new System.Drawing.Point(879, 583);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(173, 57);
            this.btnRemove.TabIndex = 44;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(498, 583);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(173, 57);
            this.btnRefresh.TabIndex = 47;
            this.btnRefresh.Text = "Refresh Table";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Trainer_DeleteTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblStatement3);
            this.Controls.Add(this.lblStatement2);
            this.Controls.Add(this.listSelectedTrainers);
            this.Controls.Add(this.lblStatement1);
            this.Controls.Add(this.lblTrainerList);
            this.Controls.Add(this.datagridTrainerList);
            this.Controls.Add(this.lblFunctionTitle);
            this.Name = "Trainer_DeleteTrainer";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.Trainer_DeleteTrainer_Load);
            this.VisibleChanged += new System.EventHandler(this.Trainer_DeleteTrainer_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.datagridTrainerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFunctionTitle;
        private System.Windows.Forms.DataGridView datagridTrainerList;
        private System.Windows.Forms.Label lblTrainerList;
        private System.Windows.Forms.Label lblStatement1;
        private System.Windows.Forms.ListBox listSelectedTrainers;
        private System.Windows.Forms.Label lblStatement2;
        private System.Windows.Forms.Label lblStatement3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRefresh;
    }
}
