namespace DB_with_forms_app
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            dataGridView = new DataGridView();
            btnOpen = new Button();
            lblTotal = new Label();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(668, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 28);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(94, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(568, 26);
            txtSearch.TabIndex = 2;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(33, 70);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 49;
            dataGridView.RowTemplate.Height = 28;
            dataGridView.Size = new Size(725, 334);
            dataGridView.TabIndex = 3;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(668, 410);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(90, 28);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(33, 415);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(102, 20);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "TptalRecords: ";
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(572, 410);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(90, 28);
            btnShowAll.TabIndex = 6;
            btnShowAll.Text = "ShowAll";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowAll);
            Controls.Add(lblTotal);
            Controls.Add(btnOpen);
            Controls.Add(dataGridView);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Open excel files & Filter Data";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dataGridView;
        private Button btnOpen;
        private Label lblTotal;
        private Button btnShowAll;
    }
}