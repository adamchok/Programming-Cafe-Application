namespace APU_Programming_Cafe.Student
{
    partial class frmPayment
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
            this.grpboxFees = new System.Windows.Forms.GroupBox();
            this.lblRMBalance = new System.Windows.Forms.Label();
            this.lblRMPaid = new System.Windows.Forms.Label();
            this.lblOutstanding = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.lblInvoiceNum = new System.Windows.Forms.Label();
            this.btnRefreshFee = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtboxInvoice = new System.Windows.Forms.TextBox();
            this.cboModuleCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboIntake = new System.Windows.Forms.ComboBox();
            this.cboPaymentMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblinv = new System.Windows.Forms.Label();
            this.lblCurrentInvoiceNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.grpboxFees.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFunctionTitle
            // 
            this.lblFunctionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFunctionTitle.AutoSize = true;
            this.lblFunctionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFunctionTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblFunctionTitle.Location = new System.Drawing.Point(436, 19);
            this.lblFunctionTitle.Name = "lblFunctionTitle";
            this.lblFunctionTitle.Size = new System.Drawing.Size(177, 46);
            this.lblFunctionTitle.TabIndex = 2;
            this.lblFunctionTitle.Text = "Payment";
            // 
            // grpboxFees
            // 
            this.grpboxFees.Controls.Add(this.lblRMBalance);
            this.grpboxFees.Controls.Add(this.lblRMPaid);
            this.grpboxFees.Controls.Add(this.lblOutstanding);
            this.grpboxFees.Controls.Add(this.lblPaid);
            this.grpboxFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxFees.ForeColor = System.Drawing.Color.Aquamarine;
            this.grpboxFees.Location = new System.Drawing.Point(44, 109);
            this.grpboxFees.Name = "grpboxFees";
            this.grpboxFees.Size = new System.Drawing.Size(986, 243);
            this.grpboxFees.TabIndex = 61;
            this.grpboxFees.TabStop = false;
            this.grpboxFees.Text = "Fees:";
            // 
            // lblRMBalance
            // 
            this.lblRMBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRMBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMBalance.ForeColor = System.Drawing.Color.White;
            this.lblRMBalance.Location = new System.Drawing.Point(620, 149);
            this.lblRMBalance.Name = "lblRMBalance";
            this.lblRMBalance.Size = new System.Drawing.Size(315, 54);
            this.lblRMBalance.TabIndex = 48;
            // 
            // lblRMPaid
            // 
            this.lblRMPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRMPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMPaid.ForeColor = System.Drawing.Color.White;
            this.lblRMPaid.Location = new System.Drawing.Point(620, 62);
            this.lblRMPaid.Name = "lblRMPaid";
            this.lblRMPaid.Size = new System.Drawing.Size(315, 54);
            this.lblRMPaid.TabIndex = 47;
            // 
            // lblOutstanding
            // 
            this.lblOutstanding.AutoSize = true;
            this.lblOutstanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutstanding.ForeColor = System.Drawing.Color.White;
            this.lblOutstanding.Location = new System.Drawing.Point(92, 150);
            this.lblOutstanding.Name = "lblOutstanding";
            this.lblOutstanding.Size = new System.Drawing.Size(349, 38);
            this.lblOutstanding.TabIndex = 46;
            this.lblOutstanding.Text = "Outstanding Balance:";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.ForeColor = System.Drawing.Color.White;
            this.lblPaid.Location = new System.Drawing.Point(92, 63);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(224, 38);
            this.lblPaid.TabIndex = 45;
            this.lblPaid.Text = "Amount Paid:";
            // 
            // lblInvoiceNum
            // 
            this.lblInvoiceNum.AutoSize = true;
            this.lblInvoiceNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceNum.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceNum.Location = new System.Drawing.Point(87, 538);
            this.lblInvoiceNum.Name = "lblInvoiceNum";
            this.lblInvoiceNum.Size = new System.Drawing.Size(310, 31);
            this.lblInvoiceNum.TabIndex = 49;
            this.lblInvoiceNum.Text = "Insert Invoice Number:";
            // 
            // btnRefreshFee
            // 
            this.btnRefreshFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRefreshFee.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnRefreshFee.Location = new System.Drawing.Point(44, 369);
            this.btnRefreshFee.Name = "btnRefreshFee";
            this.btnRefreshFee.Size = new System.Drawing.Size(200, 55);
            this.btnRefreshFee.TabIndex = 61;
            this.btnRefreshFee.Text = "Refresh ";
            this.btnRefreshFee.UseVisualStyleBackColor = true;
            this.btnRefreshFee.Click += new System.EventHandler(this.btnRefreshFee_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(27, 599);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 59;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnUpload.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnUpload.Location = new System.Drawing.Point(493, 599);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(131, 55);
            this.btnUpload.TabIndex = 58;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtboxInvoice
            // 
            this.txtboxInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtboxInvoice.Location = new System.Drawing.Point(405, 535);
            this.txtboxInvoice.Name = "txtboxInvoice";
            this.txtboxInvoice.Size = new System.Drawing.Size(347, 38);
            this.txtboxInvoice.TabIndex = 62;
            // 
            // cboModuleCode
            // 
            this.cboModuleCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModuleCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cboModuleCode.FormattingEnabled = true;
            this.cboModuleCode.IntegralHeight = false;
            this.cboModuleCode.Location = new System.Drawing.Point(493, 369);
            this.cboModuleCode.Name = "cboModuleCode";
            this.cboModuleCode.Size = new System.Drawing.Size(181, 39);
            this.cboModuleCode.TabIndex = 68;
            this.cboModuleCode.SelectedIndexChanged += new System.EventHandler(this.cboModuleCode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "ModuleCode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(688, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 69;
            this.label2.Text = "Intake:";
            // 
            // cboIntake
            // 
            this.cboIntake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIntake.Enabled = false;
            this.cboIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cboIntake.FormattingEnabled = true;
            this.cboIntake.IntegralHeight = false;
            this.cboIntake.Location = new System.Drawing.Point(798, 370);
            this.cboIntake.Name = "cboIntake";
            this.cboIntake.Size = new System.Drawing.Size(181, 39);
            this.cboIntake.TabIndex = 70;
            this.cboIntake.SelectedIndexChanged += new System.EventHandler(this.cboIntake_SelectedIndexChanged);
            // 
            // cboPaymentMonth
            // 
            this.cboPaymentMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentMonth.Enabled = false;
            this.cboPaymentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cboPaymentMonth.FormattingEnabled = true;
            this.cboPaymentMonth.IntegralHeight = false;
            this.cboPaymentMonth.Location = new System.Drawing.Point(493, 429);
            this.cboPaymentMonth.Name = "cboPaymentMonth";
            this.cboPaymentMonth.Size = new System.Drawing.Size(181, 39);
            this.cboPaymentMonth.TabIndex = 72;
            this.cboPaymentMonth.SelectedIndexChanged += new System.EventHandler(this.cboPaymentMonth_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(270, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 31);
            this.label3.TabIndex = 71;
            this.label3.Text = "PaymentMonth:";
            // 
            // lblinv
            // 
            this.lblinv.AutoSize = true;
            this.lblinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblinv.ForeColor = System.Drawing.Color.White;
            this.lblinv.Location = new System.Drawing.Point(162, 484);
            this.lblinv.Name = "lblinv";
            this.lblinv.Size = new System.Drawing.Size(323, 31);
            this.lblinv.TabIndex = 73;
            this.lblinv.Text = "Curent Invoice Number:";
            // 
            // lblCurrentInvoiceNumber
            // 
            this.lblCurrentInvoiceNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblCurrentInvoiceNumber.ForeColor = System.Drawing.Color.White;
            this.lblCurrentInvoiceNumber.Location = new System.Drawing.Point(493, 483);
            this.lblCurrentInvoiceNumber.Name = "lblCurrentInvoiceNumber";
            this.lblCurrentInvoiceNumber.Size = new System.Drawing.Size(347, 39);
            this.lblCurrentInvoiceNumber.TabIndex = 49;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(858, 483);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(172, 39);
            this.lblStatus.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(853, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 75;
            this.label5.Text = "Status:";
            // 
            // paymentDatePicker
            // 
            this.paymentDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.paymentDatePicker.Location = new System.Drawing.Point(758, 535);
            this.paymentDatePicker.Name = "paymentDatePicker";
            this.paymentDatePicker.Size = new System.Drawing.Size(276, 38);
            this.paymentDatePicker.TabIndex = 76;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.paymentDatePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCurrentInvoiceNumber);
            this.Controls.Add(this.lblinv);
            this.Controls.Add(this.cboPaymentMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboIntake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboModuleCode);
            this.Controls.Add(this.txtboxInvoice);
            this.Controls.Add(this.btnRefreshFee);
            this.Controls.Add(this.lblInvoiceNum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpboxFees);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblFunctionTitle);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "frmPayment";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.grpboxFees.ResumeLayout(false);
            this.grpboxFees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFunctionTitle;
        private System.Windows.Forms.GroupBox grpboxFees;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblOutstanding;
        private System.Windows.Forms.Label lblRMBalance;
        private System.Windows.Forms.Label lblRMPaid;
        private System.Windows.Forms.Label lblInvoiceNum;
        private System.Windows.Forms.Button btnRefreshFee;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtboxInvoice;
        private System.Windows.Forms.ComboBox cboModuleCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboIntake;
        private System.Windows.Forms.ComboBox cboPaymentMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblinv;
        private System.Windows.Forms.Label lblCurrentInvoiceNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker paymentDatePicker;
    }
}
