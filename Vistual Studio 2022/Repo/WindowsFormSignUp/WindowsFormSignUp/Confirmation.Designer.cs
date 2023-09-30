namespace WindowsFormSignUp
{
    partial class Confirmation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            lblTransaction = new Label();
            lblReports = new Label();
            lblSMS = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(289, 20);
            label1.TabIndex = 0;
            label1.Text = "Thank you. We will get back to you shortly.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 38);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 73);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 3;
            label3.Text = "Last Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 107);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 5;
            label4.Text = "E-mail: ";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(115, 38);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(26, 20);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "txt";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(115, 73);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(26, 20);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "txt";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(115, 107);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(26, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "txt";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblFirstName);
            groupBox1.Location = new Point(28, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 145);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lblTransaction);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lblReports);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(lblSMS);
            groupBox2.Location = new Point(28, 234);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(730, 145);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Service";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 38);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 1;
            label5.Text = "SMS Notification";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 73);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 3;
            label7.Text = "Reports";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 107);
            label9.Name = "label9";
            label9.Size = new Size(139, 20);
            label9.TabIndex = 5;
            label9.Text = "Transactions Report";
            // 
            // lblTransaction
            // 
            lblTransaction.AutoSize = true;
            lblTransaction.Location = new Point(188, 107);
            lblTransaction.Name = "lblTransaction";
            lblTransaction.Size = new Size(30, 20);
            lblTransaction.TabIndex = 8;
            lblTransaction.Text = "❌";
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.Location = new Point(188, 73);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(30, 20);
            lblReports.TabIndex = 7;
            lblReports.Text = "❌";
            // 
            // lblSMS
            // 
            lblSMS.AutoSize = true;
            lblSMS.Location = new Point(188, 38);
            lblSMS.Name = "lblSMS";
            lblSMS.Size = new Size(30, 20);
            lblSMS.TabIndex = 6;
            lblSMS.Text = "❌";
            // 
            // Conformation
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Conformation";
            Text = "Conformation";
            Load += Conformation_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label lblTransaction;
        private Label label7;
        private Label lblReports;
        private Label label9;
        private Label lblSMS;
    }
}