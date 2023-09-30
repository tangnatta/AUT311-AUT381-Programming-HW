namespace Simple_Calculator
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
            components = new System.ComponentModel.Container();
            txtResult = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnAdd = new Button();
            btnDivide = new Button();
            btnSubtract = new Button();
            btnTime = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnEqual = new Button();
            txtBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(29, 32);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(350, 30);
            txtResult.TabIndex = 0;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(29, 212);
            btn1.Name = "btn1";
            btn1.Size = new Size(63, 57);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += PNumber;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(98, 212);
            btn2.Name = "btn2";
            btn2.Size = new Size(63, 57);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += PNumber;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(167, 212);
            btn3.Name = "btn3";
            btn3.Size = new Size(63, 57);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += PNumber;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(29, 149);
            btn4.Name = "btn4";
            btn4.Size = new Size(63, 57);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += PNumber;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(98, 149);
            btn5.Name = "btn5";
            btn5.Size = new Size(63, 57);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += PNumber;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(167, 149);
            btn6.Name = "btn6";
            btn6.Size = new Size(63, 57);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += PNumber;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(29, 86);
            btn7.Name = "btn7";
            btn7.Size = new Size(63, 57);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += PNumber;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(98, 86);
            btn8.Name = "btn8";
            btn8.Size = new Size(63, 57);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += PNumber;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(167, 86);
            btn9.Name = "btn9";
            btn9.Size = new Size(63, 57);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += PNumber;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(29, 275);
            btn0.Name = "btn0";
            btn0.Size = new Size(132, 57);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += PNumber;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDot.Location = new Point(167, 275);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(63, 57);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += PNumber;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(247, 212);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(63, 57);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += POperator;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivide.Location = new Point(247, 86);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(63, 57);
            btnDivide.TabIndex = 12;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += POperator;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubtract.Location = new Point(247, 149);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(63, 57);
            btnSubtract.TabIndex = 13;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += POperator;
            // 
            // btnTime
            // 
            btnTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTime.Location = new Point(247, 275);
            btnTime.Name = "btnTime";
            btnTime.Size = new Size(63, 57);
            btnTime.TabIndex = 14;
            btnTime.Text = "*";
            btnTime.UseVisualStyleBackColor = true;
            btnTime.Click += POperator;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCE.Location = new Point(316, 86);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(63, 57);
            btnCE.TabIndex = 15;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnC.Location = new Point(316, 149);
            btnC.Name = "btnC";
            btnC.Size = new Size(63, 57);
            btnC.TabIndex = 16;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.Location = new Point(316, 212);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(63, 120);
            btnEqual.TabIndex = 17;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox.Location = new Point(29, 338);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(350, 30);
            txtBox.TabIndex = 18;
            txtBox.Text = "0";
            txtBox.TextAlign = HorizontalAlignment.Right;
            txtBox.KeyPress += txtBox_KeyPress;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 378);
            Controls.Add(txtBox);
            Controls.Add(btnEqual);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnTime);
            Controls.Add(btnSubtract);
            Controls.Add(btnDivide);
            Controls.Add(btnAdd);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnDot;
        private Button btnAdd;
        private Button btnDivide;
        private Button btnSubtract;
        private Button btnTime;
        private Button btnCE;
        private Button btnC;
        private Button btnEqual;
        private TextBox txtBox;
        private ContextMenuStrip contextMenuStrip1;
    }
}