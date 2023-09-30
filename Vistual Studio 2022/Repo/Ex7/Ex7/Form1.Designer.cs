namespace Ex7
{
    partial class Form1
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
            btnClose = new Button();
            gboxGender = new GroupBox();
            lblMessage = new Label();
            btnCheckGender = new Button();
            rbnFemale = new RadioButton();
            rbnMale = new RadioButton();
            chkActiviate = new CheckBox();
            lblCountries = new Label();
            cboCountry = new ComboBox();
            lblLanguage = new Label();
            gboxGender.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(353, 264);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 28);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // gboxGender
            // 
            gboxGender.Controls.Add(lblMessage);
            gboxGender.Controls.Add(btnCheckGender);
            gboxGender.Controls.Add(rbnFemale);
            gboxGender.Controls.Add(rbnMale);
            gboxGender.Location = new Point(44, 94);
            gboxGender.Name = "gboxGender";
            gboxGender.Size = new Size(399, 146);
            gboxGender.TabIndex = 1;
            gboxGender.TabStop = false;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(218, 46);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(156, 20);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Message Place Holder";
            // 
            // btnCheckGender
            // 
            btnCheckGender.Enabled = false;
            btnCheckGender.Location = new Point(247, 91);
            btnCheckGender.Name = "btnCheckGender";
            btnCheckGender.Size = new Size(127, 28);
            btnCheckGender.TabIndex = 2;
            btnCheckGender.Text = "Check Gender";
            btnCheckGender.UseVisualStyleBackColor = true;
            btnCheckGender.Click += btnCheckGender_Click;
            // 
            // rbnFemale
            // 
            rbnFemale.AutoSize = true;
            rbnFemale.Enabled = false;
            rbnFemale.Location = new Point(31, 91);
            rbnFemale.Name = "rbnFemale";
            rbnFemale.Size = new Size(75, 24);
            rbnFemale.TabIndex = 1;
            rbnFemale.TabStop = true;
            rbnFemale.Text = "Female";
            rbnFemale.UseVisualStyleBackColor = true;
            rbnFemale.CheckedChanged += rbnFemale_CheckedChanged;
            // 
            // rbnMale
            // 
            rbnMale.AutoSize = true;
            rbnMale.Enabled = false;
            rbnMale.Location = new Point(31, 46);
            rbnMale.Name = "rbnMale";
            rbnMale.Size = new Size(60, 24);
            rbnMale.TabIndex = 0;
            rbnMale.TabStop = true;
            rbnMale.Text = "Male";
            rbnMale.UseVisualStyleBackColor = true;
            rbnMale.CheckedChanged += rbnMale_CheckedChanged;
            // 
            // chkActiviate
            // 
            chkActiviate.AutoSize = true;
            chkActiviate.Location = new Point(44, 47);
            chkActiviate.Name = "chkActiviate";
            chkActiviate.Size = new Size(141, 24);
            chkActiviate.TabIndex = 3;
            chkActiviate.Text = "Activate Controls";
            chkActiviate.UseVisualStyleBackColor = true;
            chkActiviate.CheckedChanged += chkActiviate_CheckedChanged;
            // 
            // lblCountries
            // 
            lblCountries.AutoSize = true;
            lblCountries.Location = new Point(494, 51);
            lblCountries.Name = "lblCountries";
            lblCountries.Size = new Size(71, 20);
            lblCountries.TabIndex = 3;
            lblCountries.Text = "Countries";
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(494, 94);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(225, 27);
            cboCountry.TabIndex = 4;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            cboCountry.TextUpdate += cboCountry_TextUpdate;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(494, 144);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(81, 20);
            lblLanguage.TabIndex = 5;
            lblLanguage.Text = "Language: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 323);
            Controls.Add(lblLanguage);
            Controls.Add(cboCountry);
            Controls.Add(lblCountries);
            Controls.Add(chkActiviate);
            Controls.Add(gboxGender);
            Controls.Add(btnClose);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gboxGender.ResumeLayout(false);
            gboxGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private GroupBox gboxGender;
        private RadioButton rbnFemale;
        private RadioButton rbnMale;
        private Label lblMessage;
        private Button btnCheckGender;
        private CheckBox chkActiviate;
        private Label lblCountries;
        private ComboBox cboCountry;
        private Label lblLanguage;
    }
}