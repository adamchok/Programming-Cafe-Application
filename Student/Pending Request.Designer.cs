namespace APU_Programming_Cafe.Student
{
    partial class frmDeleteRequest
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPaid = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDeleteRequest = new System.Windows.Forms.Label();
            this.grpboxRequest = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboRequest = new System.Windows.Forms.ComboBox();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.lblModuleLevel = new System.Windows.Forms.Label();
            this.grpboxRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(28, 603);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 66;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.ForeColor = System.Drawing.Color.White;
            this.lblPaid.Location = new System.Drawing.Point(167, 54);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(670, 38);
            this.lblPaid.TabIndex = 45;
            this.lblPaid.Text = "Choose which request you want to cancel:";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCancel.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnCancel.Location = new System.Drawing.Point(437, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 55);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDeleteRequest
            // 
            this.lblDeleteRequest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeleteRequest.AutoSize = true;
            this.lblDeleteRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblDeleteRequest.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblDeleteRequest.Location = new System.Drawing.Point(351, 23);
            this.lblDeleteRequest.Name = "lblDeleteRequest";
            this.lblDeleteRequest.Size = new System.Drawing.Size(294, 46);
            this.lblDeleteRequest.TabIndex = 63;
            this.lblDeleteRequest.Text = "Delete Request";
            // 
            // grpboxRequest
            // 
            this.grpboxRequest.Controls.Add(this.lblModuleLevel);
            this.grpboxRequest.Controls.Add(this.lblModuleName);
            this.grpboxRequest.Controls.Add(this.btnClear);
            this.grpboxRequest.Controls.Add(this.cboRequest);
            this.grpboxRequest.Controls.Add(this.btnCancel);
            this.grpboxRequest.Controls.Add(this.lblPaid);
            this.grpboxRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxRequest.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpboxRequest.Location = new System.Drawing.Point(28, 117);
            this.grpboxRequest.Name = "grpboxRequest";
            this.grpboxRequest.Size = new System.Drawing.Size(986, 392);
            this.grpboxRequest.TabIndex = 67;
            this.grpboxRequest.TabStop = false;
            this.grpboxRequest.Text = "Cancellation:";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClear.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClear.Location = new System.Drawing.Point(648, 113);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 39);
            this.btnClear.TabIndex = 68;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboRequest
            // 
            this.cboRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cboRequest.FormattingEnabled = true;
            this.cboRequest.IntegralHeight = false;
            this.cboRequest.Location = new System.Drawing.Point(310, 113);
            this.cboRequest.Name = "cboRequest";
            this.cboRequest.Size = new System.Drawing.Size(307, 39);
            this.cboRequest.TabIndex = 67;
            this.cboRequest.SelectedIndexChanged += new System.EventHandler(this.cboRequest_SelectedIndexChanged);
            // 
            // lblModuleName
            // 
            this.lblModuleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.lblModuleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModuleName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblModuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblModuleName.Location = new System.Drawing.Point(310, 178);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(307, 33);
            this.lblModuleName.TabIndex = 69;
            // 
            // lblModuleLevel
            // 
            this.lblModuleLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.lblModuleLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModuleLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblModuleLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblModuleLevel.Location = new System.Drawing.Point(310, 231);
            this.lblModuleLevel.Name = "lblModuleLevel";
            this.lblModuleLevel.Size = new System.Drawing.Size(307, 33);
            this.lblModuleLevel.TabIndex = 70;
            // 
            // frmDeleteRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.grpboxRequest);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDeleteRequest);
            this.Name = "frmDeleteRequest";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.frmDeleteRequest_Load);
            this.VisibleChanged += new System.EventHandler(this.frmDeleteRequest_VisibleChanged);
            this.grpboxRequest.ResumeLayout(false);
            this.grpboxRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDeleteRequest;
        private System.Windows.Forms.GroupBox grpboxRequest;
        private System.Windows.Forms.ComboBox cboRequest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Label lblModuleLevel;
    }
}
