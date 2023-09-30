namespace _50pointSol
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
            btnShowAll = new Button();
            lblTotal = new Label();
            btnOpen = new Button();
            dataGridView = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            btnCal = new Button();
            txtTotal = new TextBox();
            label2 = new Label();
            txtVatAmt = new TextBox();
            lblVat = new Label();
            txtVat = new TextBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            txtLineTotal5 = new TextBox();
            txtLineTotal4 = new TextBox();
            txtLineTotal3 = new TextBox();
            txtLineTotal2 = new TextBox();
            txtLineTotal1 = new TextBox();
            lblLineTotal = new Label();
            numUnits5 = new NumericUpDown();
            numUnits4 = new NumericUpDown();
            numUnits3 = new NumericUpDown();
            numUnits2 = new NumericUpDown();
            numUnits1 = new NumericUpDown();
            lblUnit = new Label();
            txtPrice5 = new TextBox();
            txtPrice4 = new TextBox();
            txtPrice3 = new TextBox();
            txtPrice2 = new TextBox();
            lblPrice = new Label();
            lblProduct = new Label();
            txtPrice1 = new TextBox();
            txtProduct5 = new TextBox();
            txtProduct4 = new TextBox();
            txtProduct3 = new TextBox();
            txtProduct2 = new TextBox();
            txtProduct1 = new TextBox();
            btnExit = new Button();
            label3 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUnits5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUnits4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUnits3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUnits2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUnits1).BeginInit();
            SuspendLayout();
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(481, 223);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(90, 28);
            btnShowAll.TabIndex = 13;
            btnShowAll.Text = "ShowAll";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(38, 228);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(106, 20);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total Records: ";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(673, 223);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(90, 28);
            btnOpen.TabIndex = 11;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(38, 43);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 49;
            dataGridView.RowTemplate.Height = 28;
            dataGridView.Size = new Size(725, 174);
            dataGridView.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(99, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(568, 26);
            txtSearch.TabIndex = 9;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(673, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 28);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 14);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 7;
            label1.Text = "Search";
            // 
            // btnCal
            // 
            btnCal.Location = new Point(404, 531);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(90, 28);
            btnCal.TabIndex = 65;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Control;
            txtTotal.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(618, 533);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(147, 26);
            txtTotal.TabIndex = 64;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(517, 536);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 63;
            label2.Text = "Total";
            // 
            // txtVatAmt
            // 
            txtVatAmt.BackColor = Color.Yellow;
            txtVatAmt.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtVatAmt.Location = new Point(649, 501);
            txtVatAmt.Name = "txtVatAmt";
            txtVatAmt.ReadOnly = true;
            txtVatAmt.Size = new Size(116, 26);
            txtVatAmt.TabIndex = 62;
            txtVatAmt.TextAlign = HorizontalAlignment.Right;
            // 
            // lblVat
            // 
            lblVat.AutoSize = true;
            lblVat.Location = new Point(517, 504);
            lblVat.Name = "lblVat";
            lblVat.Size = new Size(50, 20);
            lblVat.TabIndex = 61;
            lblVat.Text = "VAT %";
            // 
            // txtVat
            // 
            txtVat.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtVat.Location = new Point(618, 501);
            txtVat.Name = "txtVat";
            txtVat.Size = new Size(25, 26);
            txtVat.TabIndex = 60;
            txtVat.Text = "0";
            txtVat.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(517, 472);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(67, 20);
            lblDiscount.TabIndex = 59;
            lblDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiscount.Location = new Point(618, 469);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(147, 26);
            txtDiscount.TabIndex = 58;
            txtDiscount.Text = "0";
            txtDiscount.TextAlign = HorizontalAlignment.Right;
            txtDiscount.KeyPress += txtPrice_KeyPress;
            // 
            // txtLineTotal5
            // 
            txtLineTotal5.BackColor = SystemColors.Control;
            txtLineTotal5.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtLineTotal5.Location = new Point(618, 426);
            txtLineTotal5.Name = "txtLineTotal5";
            txtLineTotal5.ReadOnly = true;
            txtLineTotal5.Size = new Size(147, 26);
            txtLineTotal5.TabIndex = 57;
            txtLineTotal5.TextAlign = HorizontalAlignment.Right;
            // 
            // txtLineTotal4
            // 
            txtLineTotal4.BackColor = SystemColors.Control;
            txtLineTotal4.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtLineTotal4.Location = new Point(618, 395);
            txtLineTotal4.Name = "txtLineTotal4";
            txtLineTotal4.ReadOnly = true;
            txtLineTotal4.Size = new Size(147, 26);
            txtLineTotal4.TabIndex = 56;
            txtLineTotal4.TextAlign = HorizontalAlignment.Right;
            // 
            // txtLineTotal3
            // 
            txtLineTotal3.BackColor = SystemColors.Control;
            txtLineTotal3.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtLineTotal3.Location = new Point(618, 363);
            txtLineTotal3.Name = "txtLineTotal3";
            txtLineTotal3.ReadOnly = true;
            txtLineTotal3.Size = new Size(147, 26);
            txtLineTotal3.TabIndex = 55;
            txtLineTotal3.TextAlign = HorizontalAlignment.Right;
            // 
            // txtLineTotal2
            // 
            txtLineTotal2.BackColor = SystemColors.Control;
            txtLineTotal2.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtLineTotal2.Location = new Point(618, 331);
            txtLineTotal2.Name = "txtLineTotal2";
            txtLineTotal2.ReadOnly = true;
            txtLineTotal2.Size = new Size(147, 26);
            txtLineTotal2.TabIndex = 54;
            txtLineTotal2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtLineTotal1
            // 
            txtLineTotal1.BackColor = SystemColors.Control;
            txtLineTotal1.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtLineTotal1.Location = new Point(618, 299);
            txtLineTotal1.Name = "txtLineTotal1";
            txtLineTotal1.ReadOnly = true;
            txtLineTotal1.Size = new Size(147, 26);
            txtLineTotal1.TabIndex = 53;
            txtLineTotal1.TextAlign = HorizontalAlignment.Right;
            // 
            // lblLineTotal
            // 
            lblLineTotal.AutoSize = true;
            lblLineTotal.Location = new Point(618, 276);
            lblLineTotal.Name = "lblLineTotal";
            lblLineTotal.Size = new Size(73, 20);
            lblLineTotal.TabIndex = 52;
            lblLineTotal.Text = "Line Total";
            // 
            // numUnits5
            // 
            numUnits5.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            numUnits5.Location = new Point(517, 427);
            numUnits5.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUnits5.Name = "numUnits5";
            numUnits5.Size = new Size(78, 26);
            numUnits5.TabIndex = 51;
            numUnits5.TextAlign = HorizontalAlignment.Right;
            numUnits5.ValueChanged += numUnit_ValueChanged;
            numUnits5.Scroll += numUnits_Scroll;
            numUnits5.KeyUp += numUnits_KeyUp;
            // 
            // numUnits4
            // 
            numUnits4.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            numUnits4.Location = new Point(517, 396);
            numUnits4.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUnits4.Name = "numUnits4";
            numUnits4.Size = new Size(78, 26);
            numUnits4.TabIndex = 50;
            numUnits4.TextAlign = HorizontalAlignment.Right;
            numUnits4.ValueChanged += numUnit_ValueChanged;
            numUnits4.Scroll += numUnits_Scroll;
            numUnits4.KeyUp += numUnits_KeyUp;
            // 
            // numUnits3
            // 
            numUnits3.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            numUnits3.Location = new Point(517, 363);
            numUnits3.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUnits3.Name = "numUnits3";
            numUnits3.Size = new Size(78, 26);
            numUnits3.TabIndex = 49;
            numUnits3.TextAlign = HorizontalAlignment.Right;
            numUnits3.ValueChanged += numUnit_ValueChanged;
            numUnits3.Scroll += numUnits_Scroll;
            numUnits3.KeyUp += numUnits_KeyUp;
            // 
            // numUnits2
            // 
            numUnits2.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            numUnits2.Location = new Point(517, 331);
            numUnits2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUnits2.Name = "numUnits2";
            numUnits2.Size = new Size(78, 26);
            numUnits2.TabIndex = 48;
            numUnits2.TextAlign = HorizontalAlignment.Right;
            numUnits2.ValueChanged += numUnit_ValueChanged;
            numUnits2.Scroll += numUnits_Scroll;
            numUnits2.KeyUp += numUnits_KeyUp;
            // 
            // numUnits1
            // 
            numUnits1.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            numUnits1.Location = new Point(517, 299);
            numUnits1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUnits1.Name = "numUnits1";
            numUnits1.Size = new Size(78, 26);
            numUnits1.TabIndex = 47;
            numUnits1.TextAlign = HorizontalAlignment.Right;
            numUnits1.ValueChanged += numUnit_ValueChanged;
            numUnits1.Scroll += numUnits_Scroll;
            numUnits1.KeyUp += numUnits_KeyUp;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(517, 276);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(36, 20);
            lblUnit.TabIndex = 46;
            lblUnit.Text = "Unit";
            // 
            // txtPrice5
            // 
            txtPrice5.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice5.Location = new Point(403, 427);
            txtPrice5.Name = "txtPrice5";
            txtPrice5.Size = new Size(91, 26);
            txtPrice5.TabIndex = 45;
            txtPrice5.TextAlign = HorizontalAlignment.Right;
            txtPrice5.KeyPress += txtPrice_KeyPress;
            // 
            // txtPrice4
            // 
            txtPrice4.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice4.Location = new Point(403, 395);
            txtPrice4.Name = "txtPrice4";
            txtPrice4.Size = new Size(91, 26);
            txtPrice4.TabIndex = 44;
            txtPrice4.TextAlign = HorizontalAlignment.Right;
            txtPrice4.KeyPress += txtPrice_KeyPress;
            // 
            // txtPrice3
            // 
            txtPrice3.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice3.Location = new Point(403, 363);
            txtPrice3.Name = "txtPrice3";
            txtPrice3.Size = new Size(91, 26);
            txtPrice3.TabIndex = 43;
            txtPrice3.TextAlign = HorizontalAlignment.Right;
            txtPrice3.KeyPress += txtPrice_KeyPress;
            // 
            // txtPrice2
            // 
            txtPrice2.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice2.Location = new Point(403, 331);
            txtPrice2.Name = "txtPrice2";
            txtPrice2.Size = new Size(91, 26);
            txtPrice2.TabIndex = 42;
            txtPrice2.TextAlign = HorizontalAlignment.Right;
            txtPrice2.KeyPress += txtPrice_KeyPress;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(403, 276);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 41;
            lblPrice.Text = "Price";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(38, 276);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(60, 20);
            lblProduct.TabIndex = 40;
            lblProduct.Text = "Product";
            // 
            // txtPrice1
            // 
            txtPrice1.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrice1.Location = new Point(403, 299);
            txtPrice1.Name = "txtPrice1";
            txtPrice1.Size = new Size(91, 26);
            txtPrice1.TabIndex = 39;
            txtPrice1.TextAlign = HorizontalAlignment.Right;
            txtPrice1.KeyPress += txtPrice_KeyPress;
            // 
            // txtProduct5
            // 
            txtProduct5.Location = new Point(38, 427);
            txtProduct5.MaxLength = 30;
            txtProduct5.Name = "txtProduct5";
            txtProduct5.Size = new Size(339, 26);
            txtProduct5.TabIndex = 38;
            // 
            // txtProduct4
            // 
            txtProduct4.Location = new Point(38, 395);
            txtProduct4.MaxLength = 30;
            txtProduct4.Name = "txtProduct4";
            txtProduct4.Size = new Size(339, 26);
            txtProduct4.TabIndex = 37;
            // 
            // txtProduct3
            // 
            txtProduct3.Location = new Point(38, 363);
            txtProduct3.MaxLength = 30;
            txtProduct3.Name = "txtProduct3";
            txtProduct3.Size = new Size(339, 26);
            txtProduct3.TabIndex = 36;
            // 
            // txtProduct2
            // 
            txtProduct2.Location = new Point(38, 331);
            txtProduct2.MaxLength = 30;
            txtProduct2.Name = "txtProduct2";
            txtProduct2.Size = new Size(339, 26);
            txtProduct2.TabIndex = 35;
            // 
            // txtProduct1
            // 
            txtProduct1.Location = new Point(38, 299);
            txtProduct1.MaxLength = 30;
            txtProduct1.Name = "txtProduct1";
            txtProduct1.Size = new Size(339, 26);
            txtProduct1.TabIndex = 34;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(38, 531);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 28);
            btnExit.TabIndex = 33;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 8.765218F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 256);
            label3.Name = "label3";
            label3.Size = new Size(738, 20);
            label3.TabIndex = 66;
            label3.Text = "---------------------------------------------------------------------------------";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(577, 223);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 28);
            btnClose.TabIndex = 67;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 591);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(btnCal);
            Controls.Add(txtTotal);
            Controls.Add(label2);
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
            Controls.Add(btnShowAll);
            Controls.Add(lblTotal);
            Controls.Add(btnOpen);
            Controls.Add(dataGridView);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Order Form & Excel Filter Data";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUnits5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUnits4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUnits3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUnits2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUnits1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowAll;
        private Label lblTotal;
        private Button btnOpen;
        private DataGridView dataGridView;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label1;
        private Button btnCal;
        private TextBox txtTotal;
        private Label label2;
        private TextBox txtVatAmt;
        private Label lblVat;
        private TextBox txtVat;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private TextBox txtLineTotal5;
        private TextBox txtLineTotal4;
        private TextBox txtLineTotal3;
        private TextBox txtLineTotal2;
        private TextBox txtLineTotal1;
        private Label lblLineTotal;
        private NumericUpDown numUnits5;
        private NumericUpDown numUnits4;
        private NumericUpDown numUnits3;
        private NumericUpDown numUnits2;
        private NumericUpDown numUnits1;
        private Label lblUnit;
        private TextBox txtPrice5;
        private TextBox txtPrice4;
        private TextBox txtPrice3;
        private TextBox txtPrice2;
        private Label lblPrice;
        private Label lblProduct;
        private TextBox txtPrice1;
        private TextBox txtProduct5;
        private TextBox txtProduct4;
        private TextBox txtProduct3;
        private TextBox txtProduct2;
        private TextBox txtProduct1;
        private Button btnExit;
        private Label label3;
        private Button btnClose;
    }
}