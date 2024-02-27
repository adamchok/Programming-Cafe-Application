namespace APU_Programming_Cafe.Admin
{
    partial class ViewFeedback
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
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rchTextMessage = new System.Windows.Forms.RichTextBox();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.rbtnComplain = new System.Windows.Forms.RadioButton();
            this.rbtnSuggestion = new System.Windows.Forms.RadioButton();
            this.lblStatement2 = new System.Windows.Forms.Label();
            this.lblStatement1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listSelectedFeedback = new System.Windows.Forms.ListBox();
            this.lblLstFeedback = new System.Windows.Forms.Label();
            this.datagridFeedback = new System.Windows.Forms.DataGridView();
            this.lblFunctionTitle = new System.Windows.Forms.Label();
            this.grpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAll
            // 
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnShowAll.Location = new System.Drawing.Point(296, 98);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(97, 30);
            this.btnShowAll.TabIndex = 82;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(502, 131);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(132, 31);
            this.lblMessage.TabIndex = 81;
            this.lblMessage.Text = "Message:";
            // 
            // rchTextMessage
            // 
            this.rchTextMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.rchTextMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchTextMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rchTextMessage.ForeColor = System.Drawing.Color.White;
            this.rchTextMessage.Location = new System.Drawing.Point(507, 165);
            this.rchTextMessage.Margin = new System.Windows.Forms.Padding(2);
            this.rchTextMessage.Name = "rchTextMessage";
            this.rchTextMessage.ReadOnly = true;
            this.rchTextMessage.Size = new System.Drawing.Size(322, 424);
            this.rchTextMessage.TabIndex = 80;
            this.rchTextMessage.Text = "";
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rbtnComplain);
            this.grpType.Controls.Add(this.rbtnSuggestion);
            this.grpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpType.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpType.Location = new System.Drawing.Point(23, 15);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(266, 113);
            this.grpType.TabIndex = 79;
            this.grpType.TabStop = false;
            this.grpType.Text = "Feedback Type:";
            // 
            // rbtnComplain
            // 
            this.rbtnComplain.AutoSize = true;
            this.rbtnComplain.Location = new System.Drawing.Point(62, 67);
            this.rbtnComplain.Name = "rbtnComplain";
            this.rbtnComplain.Size = new System.Drawing.Size(128, 29);
            this.rbtnComplain.TabIndex = 1;
            this.rbtnComplain.TabStop = true;
            this.rbtnComplain.Text = "Complain";
            this.rbtnComplain.UseVisualStyleBackColor = true;
            this.rbtnComplain.CheckedChanged += new System.EventHandler(this.rbtnComplain_CheckedChanged);
            // 
            // rbtnSuggestion
            // 
            this.rbtnSuggestion.AutoSize = true;
            this.rbtnSuggestion.Location = new System.Drawing.Point(62, 32);
            this.rbtnSuggestion.Name = "rbtnSuggestion";
            this.rbtnSuggestion.Size = new System.Drawing.Size(148, 29);
            this.rbtnSuggestion.TabIndex = 0;
            this.rbtnSuggestion.TabStop = true;
            this.rbtnSuggestion.Text = "Suggestion";
            this.rbtnSuggestion.UseVisualStyleBackColor = true;
            this.rbtnSuggestion.CheckedChanged += new System.EventHandler(this.rbtnSuggestion_CheckedChanged);
            // 
            // lblStatement2
            // 
            this.lblStatement2.AutoSize = true;
            this.lblStatement2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement2.ForeColor = System.Drawing.Color.White;
            this.lblStatement2.Location = new System.Drawing.Point(841, 149);
            this.lblStatement2.Name = "lblStatement2";
            this.lblStatement2.Size = new System.Drawing.Size(211, 13);
            this.lblStatement2.TabIndex = 78;
            this.lblStatement2.Text = "Double Click to Remove Viewed Feedback";
            // 
            // lblStatement1
            // 
            this.lblStatement1.AutoSize = true;
            this.lblStatement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement1.ForeColor = System.Drawing.Color.White;
            this.lblStatement1.Location = new System.Drawing.Point(252, 149);
            this.lblStatement1.Name = "lblStatement1";
            this.lblStatement1.Size = new System.Drawing.Size(184, 13);
            this.lblStatement1.TabIndex = 77;
            this.lblStatement1.Text = "Double Click a Row of Data to Select";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(23, 609);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 57);
            this.btnExit.TabIndex = 76;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(507, 609);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(173, 57);
            this.btnRefresh.TabIndex = 75;
            this.btnRefresh.Text = "Refresh Table";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClear.Location = new System.Drawing.Point(698, 609);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 57);
            this.btnClear.TabIndex = 74;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRemove.Location = new System.Drawing.Point(888, 609);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(173, 57);
            this.btnRemove.TabIndex = 73;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // listSelectedFeedback
            // 
            this.listSelectedFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listSelectedFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSelectedFeedback.ForeColor = System.Drawing.Color.White;
            this.listSelectedFeedback.FormattingEnabled = true;
            this.listSelectedFeedback.ItemHeight = 20;
            this.listSelectedFeedback.Location = new System.Drawing.Point(844, 165);
            this.listSelectedFeedback.Name = "listSelectedFeedback";
            this.listSelectedFeedback.Size = new System.Drawing.Size(211, 424);
            this.listSelectedFeedback.TabIndex = 72;
            this.listSelectedFeedback.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSelectedFeedback_MouseDoubleClick);
            // 
            // lblLstFeedback
            // 
            this.lblLstFeedback.AutoSize = true;
            this.lblLstFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLstFeedback.ForeColor = System.Drawing.Color.White;
            this.lblLstFeedback.Location = new System.Drawing.Point(17, 131);
            this.lblLstFeedback.Name = "lblLstFeedback";
            this.lblLstFeedback.Size = new System.Drawing.Size(229, 31);
            this.lblLstFeedback.TabIndex = 71;
            this.lblLstFeedback.Text = "List of Feedback :";
            // 
            // datagridFeedback
            // 
            this.datagridFeedback.AllowUserToAddRows = false;
            this.datagridFeedback.AllowUserToDeleteRows = false;
            this.datagridFeedback.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.datagridFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridFeedback.Location = new System.Drawing.Point(23, 165);
            this.datagridFeedback.MultiSelect = false;
            this.datagridFeedback.Name = "datagridFeedback";
            this.datagridFeedback.ReadOnly = true;
            this.datagridFeedback.RowHeadersWidth = 51;
            this.datagridFeedback.Size = new System.Drawing.Size(471, 424);
            this.datagridFeedback.TabIndex = 70;
            this.datagridFeedback.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridFeedback_CellContentDoubleClick);
            // 
            // lblFunctionTitle
            // 
            this.lblFunctionTitle.AutoSize = true;
            this.lblFunctionTitle.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunctionTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblFunctionTitle.Location = new System.Drawing.Point(401, 33);
            this.lblFunctionTitle.Name = "lblFunctionTitle";
            this.lblFunctionTitle.Size = new System.Drawing.Size(279, 43);
            this.lblFunctionTitle.TabIndex = 69;
            this.lblFunctionTitle.Text = "VIEW FEEDBACK";
            // 
            // ViewFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.rchTextMessage);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.lblStatement2);
            this.Controls.Add(this.lblStatement1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listSelectedFeedback);
            this.Controls.Add(this.lblLstFeedback);
            this.Controls.Add(this.datagridFeedback);
            this.Controls.Add(this.lblFunctionTitle);
            this.Name = "ViewFeedback";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.ViewFeedback_Load);
            this.VisibleChanged += new System.EventHandler(this.ViewFeedback_VisibleChanged);
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RichTextBox rchTextMessage;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton rbtnComplain;
        private System.Windows.Forms.RadioButton rbtnSuggestion;
        private System.Windows.Forms.Label lblStatement2;
        private System.Windows.Forms.Label lblStatement1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listSelectedFeedback;
        private System.Windows.Forms.Label lblLstFeedback;
        private System.Windows.Forms.DataGridView datagridFeedback;
        private System.Windows.Forms.Label lblFunctionTitle;
    }
}
