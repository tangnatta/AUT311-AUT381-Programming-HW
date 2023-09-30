namespace Process_bar_Process_Delay_Worker
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
            progress = new ProgressBar();
            lblPercent = new Label();
            btnStart = new Button();
            btnExit = new Button();
            btnStop = new Button();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // progress
            // 
            progress.Location = new Point(82, 107);
            progress.Name = "progress";
            progress.Size = new Size(602, 62);
            progress.TabIndex = 0;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(319, 67);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(118, 20);
            lblPercent.TabIndex = 1;
            lblPercent.Text = "Processing..... 0%";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(494, 188);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(90, 28);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(594, 280);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 28);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(594, 188);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(90, 28);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // backgroundWorker
            // 
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += backgroundWorker1_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 357);
            Controls.Add(btnStop);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Controls.Add(lblPercent);
            Controls.Add(progress);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Process";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progress;
        private Label lblPercent;
        private Button btnStart;
        private Button btnExit;
        private Button btnStop;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}