namespace MVP架構練習
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.empComboBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.overTimeGridView = new System.Windows.Forms.DataGridView();
            this.overGraphChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.overTimeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overGraphChart)).BeginInit();
            this.SuspendLayout();
            // 
            // empComboBox
            // 
            this.empComboBox.FormattingEnabled = true;
            this.empComboBox.Location = new System.Drawing.Point(165, 38);
            this.empComboBox.Name = "empComboBox";
            this.empComboBox.Size = new System.Drawing.Size(130, 23);
            this.empComboBox.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(466, 33);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 31);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "查詢";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // overTimeGridView
            // 
            this.overTimeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overTimeGridView.Location = new System.Drawing.Point(165, 70);
            this.overTimeGridView.Name = "overTimeGridView";
            this.overTimeGridView.RowHeadersWidth = 51;
            this.overTimeGridView.RowTemplate.Height = 27;
            this.overTimeGridView.Size = new System.Drawing.Size(376, 173);
            this.overTimeGridView.TabIndex = 2;
            // 
            // overGraphChart
            // 
            chartArea1.Name = "ChartArea1";
            this.overGraphChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.overGraphChart.Legends.Add(legend1);
            this.overGraphChart.Location = new System.Drawing.Point(165, 249);
            this.overGraphChart.Name = "overGraphChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.overGraphChart.Series.Add(series1);
            this.overGraphChart.Size = new System.Drawing.Size(376, 278);
            this.overGraphChart.TabIndex = 3;
            this.overGraphChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.overGraphChart);
            this.Controls.Add(this.overTimeGridView);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.empComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.overTimeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overGraphChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox empComboBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView overTimeGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart overGraphChart;
    }
}

