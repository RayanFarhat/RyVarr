﻿using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace RyVarrRevit.Analysis
{
    public partial class MemberPlot : Form
    {
        public MemberPlot(string SeriesName, double[][] xy, double len, double min_y,double max_y, string min_label, string max_label)
        {
            if (min_y == max_y)
            {
                min_y = -len;
                max_y = len;
            }

            InitializeComponent();
            var objChart = chart1.ChartAreas[0];

            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 0;
            objChart.AxisX.Maximum = len;
            objChart.AxisX.Crossing = 0;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = min_y;
            objChart.AxisY.Maximum = max_y;
            objChart.AxisY.Crossing = 0;

            chart1.Series.Clear();
            Series series = new Series(SeriesName) { ChartType = SeriesChartType.Line};
            chart1.Series.Add(series);
            chart1.Series[SeriesName].BorderWidth = 8;
            for (int i = 0; i < xy[0].Length; i++)
            {
            chart1.Series[SeriesName].Points.AddXY(xy[0][i], xy[1][i]);
            }
            objChart.AxisX.MajorGrid.Enabled = false;
            objChart.AxisY.MajorGrid.Enabled = false;

            minLabel.Text = min_label;
            maxLabel.Text = max_label;
        }
    }
}
