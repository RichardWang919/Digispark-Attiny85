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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSampleRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_voltage = new System.Windows.Forms.Label();
            this.tb_vcc = new System.Windows.Forms.TextBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSampleRate});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 358);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(562, 5);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSampleRate
            // 
            this.toolStripStatusLabelSampleRate.Name = "toolStripStatusLabelSampleRate";
            this.toolStripStatusLabelSampleRate.Size = new System.Drawing.Size(0, 0);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.Maximum = 5D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(0, 51);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.MarkerSize = 1024;
            series1.Name = "Volts";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(562, 305);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "voltageChart";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lb_voltage
            // 
            this.lb_voltage.AutoSize = true;
            this.lb_voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_voltage.ForeColor = System.Drawing.Color.Blue;
            this.lb_voltage.Location = new System.Drawing.Point(421, 2);
            this.lb_voltage.Name = "lb_voltage";
            this.lb_voltage.Size = new System.Drawing.Size(141, 46);
            this.lb_voltage.TabIndex = 3;
            this.lb_voltage.Text = "0.00 V";
            this.lb_voltage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_vcc
            // 
            this.tb_vcc.Location = new System.Drawing.Point(93, 14);
            this.tb_vcc.Name = "tb_vcc";
            this.tb_vcc.Size = new System.Drawing.Size(46, 20);
            this.tb_vcc.TabIndex = 4;
            this.tb_vcc.Text = "4.87";
            this.tb_vcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(12, 12);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 5;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.8V",
            "3.3V",
            "5V",
            "9V",
            "12V"});
            this.comboBox1.Location = new System.Drawing.Point(158, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "5V";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 363);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Btn_Start);
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
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

