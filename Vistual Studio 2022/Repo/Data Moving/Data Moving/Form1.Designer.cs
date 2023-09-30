namespace Data_Moving
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
            label1 = new Label();
            label2 = new Label();
            lstCars = new ListBox();
            lstSelectedCars = new ListBox();
            btnMoveFor = new Button();
            btnMoveWhile = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 49);
            label1.Name = "label1";
            label1.Size = new Size(52, 28);
            label1.TabIndex = 0;
            label1.Text = "Cars";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(379, 49);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 1;
            label2.Text = "Selected Cars";
            // 
            // lstCars
            // 
            lstCars.FormattingEnabled = true;
            lstCars.ItemHeight = 20;
            lstCars.Location = new Point(54, 80);
            lstCars.Name = "lstCars";
            lstCars.SelectionMode = SelectionMode.MultiExtended;
            lstCars.Size = new Size(225, 224);
            lstCars.TabIndex = 2;
            // 
            // lstSelectedCars
            // 
            lstSelectedCars.FormattingEnabled = true;
            lstSelectedCars.ItemHeight = 20;
            lstSelectedCars.Location = new Point(379, 80);
            lstSelectedCars.Name = "lstSelectedCars";
            lstSelectedCars.SelectionMode = SelectionMode.MultiExtended;
            lstSelectedCars.Size = new Size(227, 224);
            lstSelectedCars.TabIndex = 3;
            // 
            // btnMoveFor
            // 
            btnMoveFor.Location = new Point(54, 322);
            btnMoveFor.Name = "btnMoveFor";
            btnMoveFor.Size = new Size(122, 29);
            btnMoveFor.TabIndex = 4;
            btnMoveFor.Text = "Move (For)";
            btnMoveFor.UseVisualStyleBackColor = true;
            btnMoveFor.Click += btnMoveFor_Click;
            // 
            // btnMoveWhile
            // 
            btnMoveWhile.Location = new Point(379, 322);
            btnMoveWhile.Name = "btnMoveWhile";
            btnMoveWhile.Size = new Size(122, 29);
            btnMoveWhile.TabIndex = 5;
            btnMoveWhile.Text = "Move (While)";
            btnMoveWhile.UseVisualStyleBackColor = true;
            btnMoveWhile.Click += btnMoveWhile_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(54, 400);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 450);
            Controls.Add(btnExit);
            Controls.Add(btnMoveWhile);
            Controls.Add(btnMoveFor);
            Controls.Add(lstSelectedCars);
            Controls.Add(lstCars);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstCars;
        private ListBox lstSelectedCars;
        private Button btnMoveFor;
        private Button btnMoveWhile;
        private Button btnExit;
    }
}