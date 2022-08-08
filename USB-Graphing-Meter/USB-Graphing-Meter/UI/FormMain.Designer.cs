namespace GraphingMeter
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSampleRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_voltage = new System.Windows.Forms.Label();
            this.tb_vcc = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSampleRate});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 342);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(584, 20);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSampleRate
            // 
            this.toolStripStatusLabelSampleRate.Name = "toolStripStatusLabelSampleRate";
            this.toolStripStatusLabelSampleRate.Size = new System.Drawing.Size(190, 15);
            this.toolStripStatusLabelSampleRate.Text = "toolStripStatusLabelSampleRate";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.Maximum = 5D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.MarkerSize = 1024;
            series2.Name = "Volts";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(584, 339);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "voltageChart";
            // 
            // lb_voltage
            // 
            this.lb_voltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_voltage.AutoSize = true;
            this.lb_voltage.Location = new System.Drawing.Point(526, 326);
            this.lb_voltage.Name = "lb_voltage";
            this.lb_voltage.Size = new System.Drawing.Size(38, 13);
            this.lb_voltage.TabIndex = 3;
            this.lb_voltage.Text = "0.00 V";
            this.lb_voltage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_vcc
            // 
            this.tb_vcc.Location = new System.Drawing.Point(402, 323);
            this.tb_vcc.Name = "tb_vcc";
            this.tb_vcc.Size = new System.Drawing.Size(46, 20);
            this.tb_vcc.TabIndex = 4;
            this.tb_vcc.Text = "4.87";
            this.tb_vcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.tb_vcc);
            this.Controls.Add(this.lb_voltage);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.statusStrip);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphing Meter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTerminal_FormClosed);
            this.Load += new System.EventHandler(this.FormTerminal_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSampleRate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lb_voltage;
        private System.Windows.Forms.TextBox tb_vcc;
    }
}

