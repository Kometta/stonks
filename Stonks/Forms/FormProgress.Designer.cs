namespace Stonks.Forms
{
    partial class FormProgress
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPlanned = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlanned)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPlanned
            // 
            this.chartPlanned.BackColor = System.Drawing.Color.Transparent;
            this.chartPlanned.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartPlanned.BorderSkin.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.chartPlanned.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartPlanned.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.White;
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.chartPlanned.Legends.Add(legend1);
            this.chartPlanned.Location = new System.Drawing.Point(26, 22);
            this.chartPlanned.Name = "chartPlanned";
            this.chartPlanned.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Green;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series1.LabelForeColor = System.Drawing.Color.Gainsboro;
            series1.Legend = "Legend1";
            series1.Name = "Planned Expenses";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Monthly Expenses";
            this.chartPlanned.Series.Add(series1);
            this.chartPlanned.Series.Add(series2);
            this.chartPlanned.Size = new System.Drawing.Size(895, 471);
            this.chartPlanned.TabIndex = 2;
            this.chartPlanned.Text = "Expenses";
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(944, 495);
            this.Controls.Add(this.chartPlanned);
            this.Name = "FormProgress";
            this.Text = "Progress";
            this.Load += new System.EventHandler(this.FormProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPlanned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPlanned;
    }
}