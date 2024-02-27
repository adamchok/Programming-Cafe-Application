namespace APU_Programming_Cafe.Trainer
{
    partial class Feedback
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
            this.btnClearAll = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboModule = new System.Windows.Forms.ComboBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.rbtnSuggestion = new System.Windows.Forms.RadioButton();
            this.lblFeedbackType = new System.Windows.Forms.Label();
            this.rbtnComplain = new System.Windows.Forms.RadioButton();
            this.lblFunctionTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClearAll.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClearAll.Location = new System.Drawing.Point(598, 607);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(131, 55);
            this.btnClearAll.TabIndex = 46;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtMessage.Location = new System.Drawing.Point(382, 173);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(512, 243);
            this.txtMessage.TabIndex = 45;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(209, 173);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(132, 31);
            this.lblMessage.TabIndex = 44;
            this.lblMessage.Text = "Message:";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(748, 607);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 55);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSubmit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSubmit.Location = new System.Drawing.Point(898, 607);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 55);
            this.btnSubmit.TabIndex = 40;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cboModule
            // 
            this.cboModule.AllowDrop = true;
            this.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Location = new System.Drawing.Point(382, 105);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(270, 37);
            this.cboModule.TabIndex = 38;
            // 
            // lblModule
            // 
            this.lblModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblModule.ForeColor = System.Drawing.Color.White;
            this.lblModule.Location = new System.Drawing.Point(228, 105);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(110, 31);
            this.lblModule.TabIndex = 31;
            this.lblModule.Text = "Module:";
            // 
            // rbtnSuggestion
            // 
            this.rbtnSuggestion.AutoSize = true;
            this.rbtnSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSuggestion.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnSuggestion.Location = new System.Drawing.Point(384, 446);
            this.rbtnSuggestion.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnSuggestion.Name = "rbtnSuggestion";
            this.rbtnSuggestion.Size = new System.Drawing.Size(139, 30);
            this.rbtnSuggestion.TabIndex = 47;
            this.rbtnSuggestion.TabStop = true;
            this.rbtnSuggestion.Text = "Suggestion";
            this.rbtnSuggestion.UseVisualStyleBackColor = true;
            // 
            // lblFeedbackType
            // 
            this.lblFeedbackType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFeedbackType.AutoSize = true;
            this.lblFeedbackType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblFeedbackType.ForeColor = System.Drawing.Color.White;
            this.lblFeedbackType.Location = new System.Drawing.Point(136, 444);
            this.lblFeedbackType.Name = "lblFeedbackType";
            this.lblFeedbackType.Size = new System.Drawing.Size(210, 31);
            this.lblFeedbackType.TabIndex = 44;
            this.lblFeedbackType.Text = "Feedback Type:";
            // 
            // rbtnComplain
            // 
            this.rbtnComplain.AutoSize = true;
            this.rbtnComplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnComplain.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnComplain.Location = new System.Drawing.Point(612, 446);
            this.rbtnComplain.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnComplain.Name = "rbtnComplain";
            this.rbtnComplain.Size = new System.Drawing.Size(123, 30);
            this.rbtnComplain.TabIndex = 47;
            this.rbtnComplain.TabStop = true;
            this.rbtnComplain.Text = "Complain";
            this.rbtnComplain.UseVisualStyleBackColor = true;
            // 
            // lblFunctionTitle
            // 
            this.lblFunctionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFunctionTitle.AutoSize = true;
            this.lblFunctionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFunctionTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblFunctionTitle.Location = new System.Drawing.Point(374, 27);
            this.lblFunctionTitle.Name = "lblFunctionTitle";
            this.lblFunctionTitle.Size = new System.Drawing.Size(299, 46);
            this.lblFunctionTitle.TabIndex = 25;
            this.lblFunctionTitle.Text = "Feedback Form";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.rbtnComplain);
            this.Controls.Add(this.rbtnSuggestion);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblFeedbackType);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboModule);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblFunctionTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Feedback";
            this.Size = new System.Drawing.Size(1078, 681);
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.VisibleChanged += new System.EventHandler(this.Feedback_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cboModule;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.RadioButton rbtnSuggestion;
        private System.Windows.Forms.Label lblFeedbackType;
        private System.Windows.Forms.RadioButton rbtnComplain;
        private System.Windows.Forms.Label lblFunctionTitle;
    }
}
