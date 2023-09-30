namespace WindowsFormSignUp
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            lblTransactionMessage = new Label();
            lblSMSMessage = new Label();
            chkTransactions = new CheckBox();
            chkReports = new CheckBox();
            chkSMS = new CheckBox();
            btnSignUp = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 54);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name: ";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(119, 51);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(562, 26);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(119, 96);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(562, 26);
            txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 99);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Last Name: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(119, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(562, 26);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 146);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 4;
            label3.Text = "E-mail: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTransactionMessage);
            groupBox1.Controls.Add(lblSMSMessage);
            groupBox1.Controls.Add(chkTransactions);
            groupBox1.Controls.Add(chkReports);
            groupBox1.Controls.Add(chkSMS);
            groupBox1.Location = new Point(33, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 161);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Service";
            // 
            // lblTransactionMessage
            // 
            lblTransactionMessage.AutoSize = true;
            lblTransactionMessage.ForeColor = Color.RoyalBlue;
            lblTransactionMessage.Location = new Point(239, 106);
            lblTransactionMessage.Name = "lblTransactionMessage";
            lblTransactionMessage.Size = new Size(39, 20);
            lblTransactionMessage.TabIndex = 9;
            lblTransactionMessage.Text = "..........";
            // 
            // lblSMSMessage
            // 
            lblSMSMessage.AutoSize = true;
            lblSMSMessage.ForeColor = Color.Fuchsia;
            lblSMSMessage.Location = new Point(239, 46);
            lblSMSMessage.Name = "lblSMSMessage";
            lblSMSMessage.Size = new Size(39, 20);
            lblSMSMessage.TabIndex = 8;
            lblSMSMessage.Text = "..........";
            // 
            // chkTransactions
            // 
            chkTransactions.AutoSize = true;
            chkTransactions.Location = new Point(27, 104);
            chkTransactions.Name = "chkTransactions";
            chkTransactions.Size = new Size(200, 24);
            chkTransactions.TabIndex = 2;
            chkTransactions.Text = "Transactions Confirmation";
            chkTransactions.UseVisualStyleBackColor = true;
            chkTransactions.CheckedChanged += chkTransactions_CheckedChanged;
            // 
            // chkReports
            // 
            chkReports.AutoSize = true;
            chkReports.Location = new Point(27, 74);
            chkReports.Name = "chkReports";
            chkReports.Size = new Size(79, 24);
            chkReports.TabIndex = 1;
            chkReports.Text = "Reports";
            chkReports.UseVisualStyleBackColor = true;
            chkReports.CheckedChanged += chkReports_CheckedChanged;
            // 
            // chkSMS
            // 
            chkSMS.AutoSize = true;
            chkSMS.Location = new Point(27, 44);
            chkSMS.Name = "chkSMS";
            chkSMS.Size = new Size(140, 24);
            chkSMS.TabIndex = 0;
            chkSMS.Text = "SMS Notification";
            chkSMS.UseVisualStyleBackColor = true;
            chkSMS.CheckedChanged += chkSMS_CheckedChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(591, 234);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(90, 28);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(591, 294);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 28);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 450);
            Controls.Add(btnExit);
            Controls.Add(btnSignUp);
            Controls.Add(groupBox1);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private GroupBox groupBox1;
        private Label lblSMSMessage;
        private CheckBox chkTransactions;
        private CheckBox chkReports;
        private CheckBox chkSMS;
        private Button btnSignUp;
        private Label lblTransactionMessage;
        private Button btnExit;
    }
}