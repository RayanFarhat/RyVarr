﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HamzaCad.BarsComputation
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            drawVertical.Checked = BarsComputer.drawVertical;
            drawHorizontal.Checked = BarsComputer.drawHorizantal;
            drawVertical.CheckedChanged += onCheck;
            drawHorizontal.CheckedChanged += onCheck;
            ExitBtn.Click += onExitBtn;

            SpacingInput.Text = BarsComputer.BarSpacing.ToString();
            SpacingInput.ValidatingType = typeof(double);
            SpacingInput.TextChanged += onSpacing;

            withEar.Checked = BarsComputer.withEar;
            withEar.CheckedChanged += onCheck;

            EarLength.Text = BarsComputer.earLength.ToString();
            EarLength.ValidatingType = typeof(double);
            EarLength.TextChanged += onEar;

            ArrowScale.Text = BarsComputer.arrowScale.ToString();
            ArrowScale.ValidatingType = typeof(double);
            ArrowScale.TextChanged += onArrowScale;

            ArrowBlockingLineLength.Text = BarsComputer.arrowBlockingLineLength.ToString();
            ArrowBlockingLineLength.ValidatingType = typeof(double);
            ArrowBlockingLineLength.TextChanged += onArrowBlockingLineLength;

            FontSize.Text = BarsComputer.fontSize.ToString();
            FontSize.ValidatingType = typeof(double);
            FontSize.TextChanged += onFontSize;
        }
        public void onCheck(object sender, EventArgs e)
        {
            BarsComputer.drawVertical = drawVertical.Checked;
            BarsComputer.drawHorizantal=drawHorizontal.Checked;
            BarsComputer.withEar = withEar.Checked;
        }
        public void onExitBtn(object sender, EventArgs e)
        {
           this.Close();
        }
        private void onSpacing(object sender, EventArgs e)
        {
            try
            {
                BarsComputer.BarSpacing = Double.Parse(SpacingInput.Text);
            }
            catch
            {
                MessageBox.Show("Input must be a number.");
            }
        }
        private void onEar(object sender, EventArgs e)
        {
            bool allowInput = withEar.Checked;
            if (!allowInput)
            {
                EarLength.Clear();
                MessageBox.Show("Input is not allowed because the checkbox is not checked.");
            }
            else if (string.IsNullOrWhiteSpace(EarLength.Text))
            {
                MessageBox.Show("Ear Length Input cannot be empty because the checkbox is checked.");
            }
            else
            {
                try
                {
                    BarsComputer.earLength = Double.Parse(EarLength.Text);
                }
                catch {
                    MessageBox.Show("Input must be a number.");
                }
            }
        }
        private void onArrowScale(object sender, EventArgs e)
        {
            try
            {
                BarsComputer.arrowScale = Double.Parse(ArrowScale.Text);
            }
            catch
            {
                MessageBox.Show("Input must be a number.");
            }
        }
        private void onArrowBlockingLineLength(object sender, EventArgs e)
        {
            try
            {
                BarsComputer.arrowBlockingLineLength = Double.Parse(ArrowBlockingLineLength.Text);
            }
            catch
            {
                MessageBox.Show("Input must be a number.");
            }
        }
        private void onFontSize(object sender, EventArgs e)
        {
            try
            {
                BarsComputer.fontSize = Double.Parse(FontSize.Text);
            }
            catch
            {
                MessageBox.Show("Input must be a number.");
            }
        }
    }
}
