namespace Order_Form
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
            btnExit = new Button();
            txtProduct1 = new TextBox();
            txtProduct2 = new TextBox();
            txtProduct3 = new TextBox();
            txtProduct4 = new TextBox();
            txtProduct5 = new TextBox();
            txtPrice1 = new TextBox();
            lblProduct = new Label();
            lblPrice = new Label();
            txtPrice2 = new TextBox();
            txtPrice3 = new TextBox();
            txtPrice4 = new TextBox();
            txtPrice5 = new TextBox();
            lblUnit = new Label();
            numUnits1 = new NumericUpDown();
            numUnits2 = new NumericUpDown();
            numUnits3 = new NumericUpDown();
            numUnits4 = new NumericUpDown();
            numUnits5 = new NumericUpDown();
            lblLineTotal = new Label();
            txtLineTotal1 = new TextBox();
            txtLineTotal2 = new TextBox();
            txtLineTotal3 = new TextBox();
            txtLineTotal4 = new TextBox();
            txtLineTotal5 = new TextBox();
            txtDiscount = new TextBox();
            lblDiscount = new Label();
            lblVat = new Label();
            txtVat = new TextBox();
            txtVatAmt = new TextBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnCal = new Button();
            ((System.ComponentModel.ISupportInitialize)numUnits1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUnits2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUnits3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUnits4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUnits5).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(28, 360);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 28);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtProduct1
            // 
            txtProduct1.Location = new Point(28, 50);
            txtProduct1.MaxLength = 30;
            txtProduct1.Name = "txtProduct1";
            txtProduct1.Size = new Size(339, 26);
            txtProduct1.TabIndex = 1;
            // 
            // txtProduct2
            // 
            txtProduct2.Location = new Point(28, 82);
            txtProduct2.MaxLength = 30;
            txtProduct2.Name = "txtProduct2";
            txtProduct2.Size = new Size(339, 26);
            txtProduct2.TabIndex = 2;
            // 
            // txtProduct3
            // 
            txtProduct3.Location = new Point(28, 114);
            txtProduct3.MaxLength = 30;
            txtProduct3.Name = "txtProduct3";
            txtProduct3.Size = new Size(339, 26);
            txtProduct3.TabIndex = 3;
            // 
            // txtProduct4
            // 
            txtProduct4.Location = new Point(28, 146);
            txtProduct4.MaxLength = 30;
            txtProduct4.Name = "txtProduct4";
            txtProduct4.Size = new Size(339, 26);
            txtProduct4.TabIndex = 4;
            // 
            // txtProduct5
            // 
            txtProduct5.Location = new Point(28, 178);
            txtProduct5.MaxLength = 30;
            txtProduct5.Name = "txtProduct5";
            txtProduct5.Size = new Size(339, 26);
            txtProduct5.TabIndex = 5;
            // 
            // txtPrice1
            // 
            txtPrice1.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice1.Location = new Point(393, 50);
            txtPrice1.Name = "txtPrice1";
            txtPrice1.Size = new Size(91, 26);
            txtPrice1.TabIndex = 6;
            txtPrice1.Text = "0";
            txtPrice1.TextAlign = HorizontalAlignment.Right;
            txtPrice1.KeyPress += txtPrice_KeyPress;
            txtPrice1.Leave += txtPrice_leave;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(28, 27);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(60, 20);
            lblProduct.TabIndex = 7;
            lblProduct.Text = "Product";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(393, 27);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // txtPrice2
            // 
            txtPrice2.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice2.Location = new Point(393, 82);
            txtPrice2.Name = "txtPrice2";
            txtPrice2.Size = new Size(91, 26);
            txtPrice2.TabIndex = 9;
            txtPrice2.Text = "0";
            txtPrice2.TextAlign = HorizontalAlignment.Right;
            txtPrice2.KeyPress += txtPrice_KeyPress;
            txtPrice2.Leave += txtPrice_leave;
            // 
            // txtPrice3
            // 
            txtPrice3.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice3.Location = new Point(393, 114);
            txtPrice3.Name = "txtPrice3";
            txtPrice3.Size = new Size(91, 26);
            txtPrice3.TabIndex = 10;
            txtPrice3.Text = "0";
            txtPrice3.TextAlign = HorizontalAlignment.Right;
            txtPrice3.KeyPress += txtPrice_KeyPress;
            txtPrice3.Leave += txtPrice_leave;
            // 
            // txtPrice4
            // 
            txtPrice4.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice4.Location = new Point(393, 146);
            txtPrice4.Name = "txtPrice4";
            txtPrice4.Size = new Size(91, 26);
            txtPrice4.TabIndex = 11;
            txtPrice4.Text = "0";
            txtPrice4.TextAlign = HorizontalAlignment.Right;
            txtPrice4.KeyPress += txtPrice_KeyPress;
            txtPrice4.Leave += txtPrice_leave;
            // 
            // txtPrice5
            // 
            txtPrice5.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice5.Location = new Point(393, 178);
            txtPrice5.Name = "txtPrice5";
            txtPrice5.Size = new Size(91, 26);
            txtPrice5.TabIndex = 12;
            txtPrice5.Text = "0";
            txtPrice5.TextAlign = HorizontalAlignment.Right;
            txtPrice5.KeyPress += txtPrice_KeyPress;
            txtPrice5.Leave += txtPrice_leave;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(507, 27);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(36, 20);
            lblUnit.TabIndex = 13;
            lblUnit.Text = "Unit";
            // 
            // numUnits1
            // 
            numUnits1.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            numUnits1.Location = new Point(507, 50);
            numUnits1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUnits1.Name = "numUnits1";
            numUnits1.Size = new Size(78, 26);
            numUnits1.TabIndex = 14;
            numUnits1.TextAlign = HorizontalAlignment.Right;
            numUnits1.ValueChanged += numUnits1_ValueChanged;
            // 
            // numUnits2
            // 
            numUnits2.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            numUnits2.Location = new Point(507, 82);
            numUnits2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUnits2.Name = "numUnits2";
            numUnits2.Size = new Size(78, 26);
            numUnits2.TabIndex = 15;
            numUnits2.TextAlign = HorizontalAlignment.Right;
            numUnits2.ValueChanged += numUnits2_ValueChanged;
            // 
            // numUnits3
            // 
            numUnits3.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            numUnits3.Location = new Point(507, 114);
            numUnits3.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUnits3.Name = "numUnits3";
            numUnits3.Size = new Size(78, 26);
            numUnits3.TabIndex = 16;
            numUnits3.TextAlign = HorizontalAlignment.Right;
            numUnits3.ValueChanged += numUnits3_ValueChanged;
            // 
            // numUnits4
            // 
            numUnits4.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            numUnits4.Location = new Point(507, 147);
            numUnits4.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUnits4.Name = "numUnits4";
            numUnits4.Size = new Size(78, 26);
            numUnits4.TabIndex = 17;
            numUnits4.TextAlign = HorizontalAlignment.Right;
            numUnits4.ValueChanged += numUnits4_ValueChanged;
            // 
            // numUnits5
            // 
            numUnits5.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            numUnits5.Location = new Point(507, 178);
            numUnits5.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUnits5.Name = "numUnits5";
            numUnits5.Size = new Size(78, 26);
            numUnits5.TabIndex = 18;
            numUnits5.TextAlign = HorizontalAlignment.Right;
            numUnits5.ValueChanged += numUnits5_ValueChanged;
            // 
            // lblLineTotal
            // 
            lblLineTotal.AutoSize = true;
            lblLineTotal.Location = new Point(608, 27);
            lblLineTotal.Name = "lblLineTotal";
            lblLineTotal.Size = new Size(73, 20);
            lblLineTotal.TabIndex = 19;
            lblLineTotal.Text = "Line Total";
            // 
            // txtLineTotal1
            // 
            txtLineTotal1.BackColor = SystemColors.Control;
            txtLineTotal1.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtLineTotal1.Location = new Point(608, 50);
            txtLineTotal1.Name = "txtLineTotal1";
            txtLineTotal1.ReadOnly = true;
            txtLineTotal1.Size = new Size(147, 26);
            txtLineTotal1.TabIndex = 20;
            txtLineTotal1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtLineTotal2
            // 
            txtLineTotal2.BackColor = SystemColors.Control;
            txtLineTotal2.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtLineTotal2.Location = new Point(608, 82);
            txtLineTotal2.Name = "txtLineTotal2";
            txtLineTotal2.ReadOnly = true;
            txtLineTotal2.Size = new Size(147, 26);
            txtLineTotal2.TabIndex = 21;
            txtLineTotal2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtLineTotal3
            // 
            txtLineTotal3.BackColor = SystemColors.Control;
            txtLineTotal3.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtLineTotal3.Location = new Point(608, 114);
            txtLineTotal3.Name = "txtLineTotal3";
            txtLineTotal3.ReadOnly = true;
            txtLineTotal3.Size = new Size(147, 26);
            txtLineTotal3.TabIndex = 22;
            txtLineTotal3.TextAlign = HorizontalAlignment.Right;
            // 
            // txtLineTotal4
            // 
            txtLineTotal4.BackColor = SystemColors.Control;
            txtLineTotal4.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtLineTotal4.Location = new Point(608, 146);
            txtLineTotal4.Name = "txtLineTotal4";
            txtLineTotal4.ReadOnly = true;
            txtLineTotal4.Size = new Size(147, 26);
            txtLineTotal4.TabIndex = 23;
            txtLineTotal4.TextAlign = HorizontalAlignment.Right;
            // 
            // txtLineTotal5
            // 
            txtLineTotal5.BackColor = SystemColors.Control;
            txtLineTotal5.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtLineTotal5.Location = new Point(608, 177);
            txtLineTotal5.Name = "txtLineTotal5";
            txtLineTotal5.ReadOnly = true;
            txtLineTotal5.Size = new Size(147, 26);
            txtLineTotal5.TabIndex = 24;
            txtLineTotal5.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiscount.Location = new Point(608, 236);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(147, 26);
            txtDiscount.TabIndex = 25;
            txtDiscount.Text = "0";
            txtDiscount.TextAlign = HorizontalAlignment.Right;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(507, 239);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(67, 20);
            lblDiscount.TabIndex = 26;
            lblDiscount.Text = "Discount";
            // 
            // lblVat
            // 
            lblVat.AutoSize = true;
            lblVat.Location = new Point(507, 271);
            lblVat.Name = "lblVat";
            lblVat.Size = new Size(50, 20);
            lblVat.TabIndex = 28;
            lblVat.Text = "VAT %";
            // 
            // txtVat
            // 
            txtVat.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtVat.Location = new Point(608, 268);
            txtVat.Name = "txtVat";
            txtVat.Size = new Size(25, 26);
            txtVat.TabIndex = 27;
            txtVat.Text = "0";
            txtVat.TextAlign = HorizontalAlignment.Right;
            txtVat.TextChanged += txtVat_TextChanged;
            // 
            // txtVatAmt
            // 
            txtVatAmt.BackColor = Color.Yellow;
            txtVatAmt.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtVatAmt.Location = new Point(639, 268);
            txtVatAmt.Name = "txtVatAmt";
            txtVatAmt.ReadOnly = true;
            txtVatAmt.Size = new Size(116, 26);
            txtVatAmt.TabIndex = 29;
            txtVatAmt.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(507, 303);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Control;
            txtTotal.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(608, 300);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(147, 26);
            txtTotal.TabIndex = 31;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(665, 360);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(90, 28);
            btnCal.TabIndex = 32;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 414);
            Controls.Add(btnCal);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(txtVatAmt);
            Controls.Add(lblVat);
            Controls.Add(txtVat);
            Controls.Add(lblDiscount);
            Controls.Add(txtDiscount);
            Controls.Add(txtLineTotal5);
            Controls.Add(txtLineTotal4);
            Controls.Add(txtLineTotal3);
            Controls.Add(txtLineTotal2);
            Controls.Add(txtLineTotal1);
            Controls.Add(lblLineTotal);
            Controls.Add(numUnits5);
            Controls.Add(numUnits4);
            Controls.Add(numUnits3);
            Controls.Add(numUnits2);
            Controls.Add(numUnits1);
            Controls.Add(lblUnit);
            Controls.Add(txtPrice5);
            Controls.Add(txtPrice4);
            Controls.Add(txtPrice3);
            Controls.Add(txtPrice2);
            Controls.Add(lblPrice);
            Controls.Add(lblProduct);
            Controls.Add(txtPrice1);
            Controls.Add(txtProduct5);
            Controls.Add(txtProduct4);
            Controls.Add(txtProduct3);
            Controls.Add(txtProduct2);
            Controls.Add(txtProduct1);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numUnits1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUnits2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUnits3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUnits4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUnits5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private TextBox txtProduct1;
        private TextBox txtProduct2;
        private TextBox txtProduct3;
        private TextBox txtProduct4;
        private TextBox txtProduct5;
        private TextBox txtPrice1;
        private Label lblProduct;
        private Label lblPrice;
        private TextBox txtPrice2;
        private TextBox txtPrice3;
        private TextBox txtPrice4;
        private TextBox txtPrice5;
        private Label lblUnit;
        private NumericUpDown numUnits1;
        private NumericUpDown numUnits2;
        private NumericUpDown numUnits3;
        private NumericUpDown numUnits4;
        private NumericUpDown numUnits5;
        private Label lblLineTotal;
        private TextBox txtLineTotal1;
        private TextBox txtLineTotal2;
        private TextBox txtLineTotal3;
        private TextBox txtLineTotal4;
        private TextBox txtLineTotal5;
        private TextBox txtDiscount;
        private Label lblDiscount;
        private Label lblVat;
        private TextBox txtVat;
        private TextBox txtVatAmt;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnCal;
    }
}