namespace Add_Calculator
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
            txtN01 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtN02 = new TextBox();
            label3 = new Label();
            txtResult = new TextBox();
            btnSubtract = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtN01
            // 
            txtN01.Location = new Point(27, 56);
            txtN01.Name = "txtN01";
            txtN01.Size = new Size(269, 27);
            txtN01.TabIndex = 0;
            txtN01.Text = "0";
            txtN01.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 33);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Number 2";
            // 
            // txtN02
            // 
            txtN02.Location = new Point(348, 56);
            txtN02.Name = "txtN02";
            txtN02.Size = new Size(269, 27);
            txtN02.TabIndex = 3;
            txtN02.Text = "0";
            txtN02.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 132);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Result";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(82, 129);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(435, 27);
            txtResult.TabIndex = 5;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(523, 132);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(94, 29);
            btnSubtract.TabIndex = 6;
            btnSubtract.Text = "Subtract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(523, 193);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 253);
            Controls.Add(btnClose);
            Controls.Add(btnSubtract);
            Controls.Add(txtResult);
            Controls.Add(label3);
            Controls.Add(txtN02);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtN01);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtN01;
        private Label label1;
        private Label label2;
        private TextBox txtN02;
        private Label label3;
        private TextBox txtResult;
        private Button btnSubtract;
        private Button btnClose;
    }
}