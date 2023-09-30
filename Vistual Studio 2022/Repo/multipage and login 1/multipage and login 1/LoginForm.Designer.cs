namespace multipage_and_login_1
{
    partial class LoginForm
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
            lblUID = new Label();
            txtUID = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            button1 = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // lblUID
            // 
            lblUID.AutoSize = true;
            lblUID.Location = new Point(40, 36);
            lblUID.Name = "lblUID";
            lblUID.Size = new Size(41, 20);
            lblUID.TabIndex = 0;
            lblUID.Text = "UID: ";
            // 
            // txtUID
            // 
            txtUID.Location = new Point(123, 33);
            txtUID.Name = "txtUID";
            txtUID.Size = new Size(336, 26);
            txtUID.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(123, 74);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(336, 26);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 80);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password: ";
            // 
            // button1
            // 
            button1.Location = new Point(137, 134);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(265, 134);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(90, 28);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 201);
            Controls.Add(btnReset);
            Controls.Add(button1);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUID);
            Controls.Add(lblUID);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUID;
        private TextBox txtUID;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button button1;
        private Button btnReset;
    }
}