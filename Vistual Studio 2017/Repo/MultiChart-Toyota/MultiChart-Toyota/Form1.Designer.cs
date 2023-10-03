namespace MultiChart_Toyota
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartEmName = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chartCountry = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.chartTimeRev = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartEmSal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFuRev = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTimeRev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuRev)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEmName
            // 
            chartArea11.Name = "ChartArea1";
            this.chartEmName.ChartAreas.Add(chartArea11);
            legend11.Enabled = false;
            legend11.Name = "Legend1";
            this.chartEmName.Legends.Add(legend11);
            this.chartEmName.Location = new System.Drawing.Point(12, 29);
            this.chartEmName.Name = "chartEmName";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series17.Legend = "Legend1";
            series17.Name = "EmployerName";
            series17.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chartEmName.Series.Add(series17);
            this.chartEmName.Size = new System.Drawing.Size(461, 215);
            this.chartEmName.TabIndex = 0;
            this.chartEmName.Text = "Employer Name VS SKU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employer Name VS SKU";
            // 
            // chartCountry
            // 
            chartArea12.Name = "ChartArea1";
            this.chartCountry.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chartCountry.Legends.Add(legend12);
            this.chartCountry.Location = new System.Drawing.Point(479, 29);
            this.chartCountry.Name = "chartCountry";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series18.Legend = "Legend1";
            series18.Name = "Country";
            series18.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chartCountry.Series.Add(series18);
            this.chartCountry.Size = new System.Drawing.Size(461, 215);
            this.chartCountry.TabIndex = 2;
            this.chartCountry.Text = "Sales by Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sales by Country";
            // 
            // chartTimeRev
            // 
            chartArea13.Name = "ChartArea1";
            this.chartTimeRev.ChartAreas.Add(chartArea13);
            legend13.Enabled = false;
            legend13.Name = "Legend1";
            this.chartTimeRev.Legends.Add(legend13);
            this.chartTimeRev.Location = new System.Drawing.Point(479, 270);
            this.chartTimeRev.Name = "chartTimeRev";
            series19.BorderWidth = 3;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Legend = "Legend1";
            series19.Name = "TimeRev";
            series19.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chartTimeRev.Series.Add(series19);
            this.chartTimeRev.Size = new System.Drawing.Size(461, 215);
            this.chartTimeRev.TabIndex = 4;
            this.chartTimeRev.Text = "Five-year sales car revenue.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Five-year sales car revenue.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Five-year employer Salary";
            // 
            // chartEmSal
            // 
            chartArea14.Name = "ChartArea1";
            this.chartEmSal.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chartEmSal.Legends.Add(legend14);
            this.chartEmSal.Location = new System.Drawing.Point(12, 270);
            this.chartEmSal.Name = "chartEmSal";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Paul";
            series20.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "John";
            series22.ChartArea = "ChartArea1";
            series22.Legend = "Legend1";
            series22.Name = "Michael";
            series23.ChartArea = "ChartArea1";
            series23.Legend = "Legend1";
            series23.Name = "Davide";
            this.chartEmSal.Series.Add(series20);
            this.chartEmSal.Series.Add(series21);
            this.chartEmSal.Series.Add(series22);
            this.chartEmSal.Series.Add(series23);
            this.chartEmSal.Size = new System.Drawing.Size(461, 215);
            this.chartEmSal.TabIndex = 6;
            this.chartEmSal.Text = "Employer Salary";
            // 
            // chartFuRev
            // 
            chartArea15.Name = "ChartArea1";
            this.chartFuRev.ChartAreas.Add(chartArea15);
            legend15.Enabled = false;
            legend15.Name = "Legend1";
            this.chartFuRev.Legends.Add(legend15);
            this.chartFuRev.Location = new System.Drawing.Point(9, 512);
            this.chartFuRev.Name = "chartFuRev";
            series24.BorderWidth = 3;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Legend = "Legend1";
            series24.Name = "TimeRev";
            series24.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chartFuRev.Series.Add(series24);
            this.chartFuRev.Size = new System.Drawing.Size(931, 215);
            this.chartFuRev.TabIndex = 8;
            this.chartFuRev.Text = "Ten-year forecast revenue (2024-2034)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ten-year forecast revenue (2024-2034)";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(865, 739);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(9, 739);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 774);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chartFuRev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chartEmSal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartTimeRev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartEmName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTimeRev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFuRev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTimeRev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmSal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFuRev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
    }
}

