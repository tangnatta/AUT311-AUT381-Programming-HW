namespace MultiLiveChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartStu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProf
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProf.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProf.Legends.Add(legend1);
            this.chartProf.Location = new System.Drawing.Point(284, 12);
            this.chartProf.Name = "chartProf";
            this.chartProf.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.GhostWhite;
            series1.Legend = "Legend1";
            series1.Name = "Professors";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chartProf.Series.Add(series1);
            this.chartProf.Size = new System.Drawing.Size(266, 165);
            this.chartProf.TabIndex = 3;
            this.chartProf.Text = "chart2";
            // 
            // chartStu
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStu.Legends.Add(legend2);
            this.chartStu.Location = new System.Drawing.Point(12, 12);
            this.chartStu.Name = "chartStu";
            this.chartStu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Students";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chartStu.Series.Add(series2);
            this.chartStu.Size = new System.Drawing.Size(266, 165);
            this.chartStu.TabIndex = 4;
            this.chartStu.Text = "chart1";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(20, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(746, 415);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chartPie
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPie.Legends.Add(legend3);
            this.chartPie.Location = new System.Drawing.Point(556, 12);
            this.chartPie.Name = "chartPie";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Color = System.Drawing.Color.Fuchsia;
            series3.Legend = "Legend1";
            series3.Name = "Performance";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chartPie.Series.Add(series3);
            this.chartPie.Size = new System.Drawing.Size(266, 165);
            this.chartPie.TabIndex = 7;
            this.chartPie.Text = "chart3";
            // 
            // chartLine
            // 
            chartArea4.Name = "ChartArea1";
            this.chartLine.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartLine.Legends.Add(legend4);
            this.chartLine.Location = new System.Drawing.Point(12, 183);
            this.chartLine.Name = "chartLine";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Results";
            series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chartLine.Series.Add(series4);
            this.chartLine.Size = new System.Drawing.Size(810, 165);
            this.chartLine.TabIndex = 8;
            this.chartLine.Text = "chart4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.chartLine);
            this.Controls.Add(this.chartPie);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chartStu);
            this.Controls.Add(this.chartProf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProf;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLine;
    }
}

