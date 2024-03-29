﻿namespace HamzaCad.BarsComputation
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.drawVertical = new System.Windows.Forms.CheckBox();
            this.drawHorizontal = new System.Windows.Forms.CheckBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.spacingLabel = new System.Windows.Forms.Label();
            this.SpacingInput = new System.Windows.Forms.MaskedTextBox();
            this.withEar = new System.Windows.Forms.CheckBox();
            this.earLabel = new System.Windows.Forms.Label();
            this.EarLength = new System.Windows.Forms.MaskedTextBox();
            this.arrowSizelabel = new System.Windows.Forms.Label();
            this.ArrowSize = new System.Windows.Forms.MaskedTextBox();
            this.ArrowBlockingLineLengthLabel = new System.Windows.Forms.Label();
            this.ArrowBlockingLineLength = new System.Windows.Forms.MaskedTextBox();
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.FontSize = new System.Windows.Forms.MaskedTextBox();
            this.Eng = new System.Windows.Forms.RadioButton();
            this.Heb = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TopBars = new System.Windows.Forms.RadioButton();
            this.BottomBars = new System.Windows.Forms.RadioButton();
            this.DiameterLabel = new System.Windows.Forms.Label();
            this.Diameter = new System.Windows.Forms.MaskedTextBox();
            this.BarPolySpace = new System.Windows.Forms.MaskedTextBox();
            this.BarPolySpaceLabel = new System.Windows.Forms.Label();
            this.TextEditorBtn = new System.Windows.Forms.Button();
            this.MaxBarLength = new System.Windows.Forms.MaskedTextBox();
            this.MaxBarLengthLabel = new System.Windows.Forms.Label();
            this.MeetingCircleRadius = new System.Windows.Forms.MaskedTextBox();
            this.MeetingCircleRadiusLabel = new System.Windows.Forms.Label();
            this.IronColor = new System.Windows.Forms.ComboBox();
            this.IronColorLabel = new System.Windows.Forms.Label();
            this.IronLineWeight = new System.Windows.Forms.ComboBox();
            this.IronLineWeightLabel = new System.Windows.Forms.Label();
            this.AuthWinBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawVertical
            // 
            this.drawVertical.AutoSize = true;
            this.drawVertical.Location = new System.Drawing.Point(231, 54);
            this.drawVertical.Name = "drawVertical";
            this.drawVertical.Size = new System.Drawing.Size(104, 20);
            this.drawVertical.TabIndex = 0;
            this.drawVertical.Text = "draw vertical";
            this.drawVertical.UseVisualStyleBackColor = true;
            // 
            // drawHorizontal
            // 
            this.drawHorizontal.AutoSize = true;
            this.drawHorizontal.Location = new System.Drawing.Point(231, 93);
            this.drawHorizontal.Name = "drawHorizontal";
            this.drawHorizontal.Size = new System.Drawing.Size(118, 20);
            this.drawHorizontal.TabIndex = 1;
            this.drawHorizontal.Text = "draw horizontal";
            this.drawHorizontal.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(231, 378);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(86, 63);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Draw";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // spacingLabel
            // 
            this.spacingLabel.Location = new System.Drawing.Point(50, 54);
            this.spacingLabel.Name = "spacingLabel";
            this.spacingLabel.Size = new System.Drawing.Size(86, 27);
            this.spacingLabel.TabIndex = 0;
            this.spacingLabel.Text = "Spacing";
            // 
            // SpacingInput
            // 
            this.SpacingInput.Location = new System.Drawing.Point(36, 75);
            this.SpacingInput.Name = "SpacingInput";
            this.SpacingInput.Size = new System.Drawing.Size(100, 22);
            this.SpacingInput.TabIndex = 4;
            // 
            // withEar
            // 
            this.withEar.AutoSize = true;
            this.withEar.Location = new System.Drawing.Point(448, 54);
            this.withEar.Name = "withEar";
            this.withEar.Size = new System.Drawing.Size(79, 20);
            this.withEar.TabIndex = 5;
            this.withEar.Text = "With Ear";
            this.withEar.UseVisualStyleBackColor = true;
            // 
            // earLabel
            // 
            this.earLabel.AutoSize = true;
            this.earLabel.Location = new System.Drawing.Point(445, 90);
            this.earLabel.Name = "earLabel";
            this.earLabel.Size = new System.Drawing.Size(71, 16);
            this.earLabel.TabIndex = 8;
            this.earLabel.Text = "Ear Length";
            // 
            // EarLength
            // 
            this.EarLength.Location = new System.Drawing.Point(448, 110);
            this.EarLength.Name = "EarLength";
            this.EarLength.Size = new System.Drawing.Size(100, 22);
            this.EarLength.TabIndex = 9;
            // 
            // arrowSizelabel
            // 
            this.arrowSizelabel.AutoSize = true;
            this.arrowSizelabel.Location = new System.Drawing.Point(448, 151);
            this.arrowSizelabel.Name = "arrowSizelabel";
            this.arrowSizelabel.Size = new System.Drawing.Size(70, 16);
            this.arrowSizelabel.TabIndex = 10;
            this.arrowSizelabel.Text = "Arrow Size";
            // 
            // ArrowSize
            // 
            this.ArrowSize.Location = new System.Drawing.Point(448, 170);
            this.ArrowSize.Name = "ArrowSize";
            this.ArrowSize.Size = new System.Drawing.Size(100, 22);
            this.ArrowSize.TabIndex = 11;
            // 
            // ArrowBlockingLineLengthLabel
            // 
            this.ArrowBlockingLineLengthLabel.AutoSize = true;
            this.ArrowBlockingLineLengthLabel.Location = new System.Drawing.Point(424, 205);
            this.ArrowBlockingLineLengthLabel.Name = "ArrowBlockingLineLengthLabel";
            this.ArrowBlockingLineLengthLabel.Size = new System.Drawing.Size(167, 16);
            this.ArrowBlockingLineLengthLabel.TabIndex = 12;
            this.ArrowBlockingLineLengthLabel.Text = "Arrow Blocking Line Length";
            // 
            // ArrowBlockingLineLength
            // 
            this.ArrowBlockingLineLength.Location = new System.Drawing.Point(427, 233);
            this.ArrowBlockingLineLength.Name = "ArrowBlockingLineLength";
            this.ArrowBlockingLineLength.Size = new System.Drawing.Size(100, 22);
            this.ArrowBlockingLineLength.TabIndex = 13;
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.AutoSize = true;
            this.FontSizeLabel.Location = new System.Drawing.Point(36, 121);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(62, 16);
            this.FontSizeLabel.TabIndex = 14;
            this.FontSizeLabel.Text = "Font Size";
            // 
            // FontSize
            // 
            this.FontSize.Location = new System.Drawing.Point(36, 151);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(100, 22);
            this.FontSize.TabIndex = 15;
            // 
            // Eng
            // 
            this.Eng.AutoSize = true;
            this.Eng.Checked = true;
            this.Eng.Location = new System.Drawing.Point(3, 3);
            this.Eng.Name = "Eng";
            this.Eng.Size = new System.Drawing.Size(52, 20);
            this.Eng.TabIndex = 16;
            this.Eng.TabStop = true;
            this.Eng.Text = "Eng";
            this.Eng.UseVisualStyleBackColor = true;
            // 
            // Heb
            // 
            this.Heb.AutoSize = true;
            this.Heb.Location = new System.Drawing.Point(61, 3);
            this.Heb.Name = "Heb";
            this.Heb.Size = new System.Drawing.Size(54, 20);
            this.Heb.TabIndex = 17;
            this.Heb.Text = "Heb";
            this.Heb.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Eng);
            this.panel1.Controls.Add(this.Heb);
            this.panel1.Location = new System.Drawing.Point(87, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 29);
            this.panel1.TabIndex = 18;
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(12, 9);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(71, 16);
            this.LanguageLabel.TabIndex = 19;
            this.LanguageLabel.Text = "Language:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TopBars);
            this.panel2.Controls.Add(this.BottomBars);
            this.panel2.Location = new System.Drawing.Point(222, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 38);
            this.panel2.TabIndex = 19;
            // 
            // TopBars
            // 
            this.TopBars.AutoSize = true;
            this.TopBars.Checked = true;
            this.TopBars.Location = new System.Drawing.Point(3, 3);
            this.TopBars.Name = "TopBars";
            this.TopBars.Size = new System.Drawing.Size(91, 20);
            this.TopBars.TabIndex = 16;
            this.TopBars.TabStop = true;
            this.TopBars.Text = "Upper Iron";
            this.TopBars.UseVisualStyleBackColor = true;
            // 
            // BottomBars
            // 
            this.BottomBars.AutoSize = true;
            this.BottomBars.Location = new System.Drawing.Point(100, 3);
            this.BottomBars.Name = "BottomBars";
            this.BottomBars.Size = new System.Drawing.Size(89, 20);
            this.BottomBars.TabIndex = 17;
            this.BottomBars.Text = "Lower Iron";
            this.BottomBars.UseVisualStyleBackColor = true;
            // 
            // DiameterLabel
            // 
            this.DiameterLabel.AutoSize = true;
            this.DiameterLabel.Location = new System.Drawing.Point(36, 204);
            this.DiameterLabel.Name = "DiameterLabel";
            this.DiameterLabel.Size = new System.Drawing.Size(62, 16);
            this.DiameterLabel.TabIndex = 20;
            this.DiameterLabel.Text = "Diameter";
            // 
            // Diameter
            // 
            this.Diameter.Location = new System.Drawing.Point(36, 233);
            this.Diameter.Name = "Diameter";
            this.Diameter.Size = new System.Drawing.Size(100, 22);
            this.Diameter.TabIndex = 21;
            // 
            // BarPolySpace
            // 
            this.BarPolySpace.Location = new System.Drawing.Point(189, 233);
            this.BarPolySpace.Name = "BarPolySpace";
            this.BarPolySpace.Size = new System.Drawing.Size(100, 22);
            this.BarPolySpace.TabIndex = 23;
            // 
            // BarPolySpaceLabel
            // 
            this.BarPolySpaceLabel.AutoSize = true;
            this.BarPolySpaceLabel.Location = new System.Drawing.Point(189, 204);
            this.BarPolySpaceLabel.Name = "BarPolySpaceLabel";
            this.BarPolySpaceLabel.Size = new System.Drawing.Size(200, 16);
            this.BarPolySpaceLabel.TabIndex = 22;
            this.BarPolySpaceLabel.Text = "Space between bar and polyline";
            // 
            // TextEditorBtn
            // 
            this.TextEditorBtn.Location = new System.Drawing.Point(231, 7);
            this.TextEditorBtn.Name = "TextEditorBtn";
            this.TextEditorBtn.Size = new System.Drawing.Size(104, 23);
            this.TextEditorBtn.TabIndex = 24;
            this.TextEditorBtn.Text = "Text Editor";
            this.TextEditorBtn.UseVisualStyleBackColor = true;
            // 
            // MaxBarLength
            // 
            this.MaxBarLength.Location = new System.Drawing.Point(36, 303);
            this.MaxBarLength.Name = "MaxBarLength";
            this.MaxBarLength.Size = new System.Drawing.Size(100, 22);
            this.MaxBarLength.TabIndex = 26;
            // 
            // MaxBarLengthLabel
            // 
            this.MaxBarLengthLabel.AutoSize = true;
            this.MaxBarLengthLabel.Location = new System.Drawing.Point(36, 274);
            this.MaxBarLengthLabel.Name = "MaxBarLengthLabel";
            this.MaxBarLengthLabel.Size = new System.Drawing.Size(94, 16);
            this.MaxBarLengthLabel.TabIndex = 25;
            this.MaxBarLengthLabel.Text = "Max bar length";
            // 
            // MeetingCircleRadius
            // 
            this.MeetingCircleRadius.Location = new System.Drawing.Point(186, 303);
            this.MeetingCircleRadius.Name = "MeetingCircleRadius";
            this.MeetingCircleRadius.Size = new System.Drawing.Size(100, 22);
            this.MeetingCircleRadius.TabIndex = 28;
            // 
            // MeetingCircleRadiusLabel
            // 
            this.MeetingCircleRadiusLabel.AutoSize = true;
            this.MeetingCircleRadiusLabel.Location = new System.Drawing.Point(186, 274);
            this.MeetingCircleRadiusLabel.Name = "MeetingCircleRadiusLabel";
            this.MeetingCircleRadiusLabel.Size = new System.Drawing.Size(138, 16);
            this.MeetingCircleRadiusLabel.TabIndex = 27;
            this.MeetingCircleRadiusLabel.Text = "Meeting Circle Radius";
            // 
            // IronColor
            // 
            this.IronColor.FormattingEnabled = true;
            this.IronColor.Location = new System.Drawing.Point(372, 301);
            this.IronColor.Name = "IronColor";
            this.IronColor.Size = new System.Drawing.Size(121, 24);
            this.IronColor.TabIndex = 29;
            // 
            // IronColorLabel
            // 
            this.IronColorLabel.AutoSize = true;
            this.IronColorLabel.Location = new System.Drawing.Point(372, 279);
            this.IronColorLabel.Name = "IronColorLabel";
            this.IronColorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IronColorLabel.Size = new System.Drawing.Size(64, 16);
            this.IronColorLabel.TabIndex = 30;
            this.IronColorLabel.Text = "Iron Color";
            // 
            // IronLineWeight
            // 
            this.IronLineWeight.FormattingEnabled = true;
            this.IronLineWeight.Location = new System.Drawing.Point(525, 303);
            this.IronLineWeight.Name = "IronLineWeight";
            this.IronLineWeight.Size = new System.Drawing.Size(121, 24);
            this.IronLineWeight.TabIndex = 31;
            // 
            // IronLineWeightLabel
            // 
            this.IronLineWeightLabel.AutoSize = true;
            this.IronLineWeightLabel.Location = new System.Drawing.Point(527, 279);
            this.IronLineWeightLabel.Name = "IronLineWeightLabel";
            this.IronLineWeightLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IronLineWeightLabel.Size = new System.Drawing.Size(99, 16);
            this.IronLineWeightLabel.TabIndex = 32;
            this.IronLineWeightLabel.Text = "Iron LineWeight";
            // 
            // AuthWinBtn
            // 
            this.AuthWinBtn.BackColor = System.Drawing.Color.Wheat;
            this.AuthWinBtn.Location = new System.Drawing.Point(566, 6);
            this.AuthWinBtn.Name = "AuthWinBtn";
            this.AuthWinBtn.Size = new System.Drawing.Size(104, 23);
            this.AuthWinBtn.TabIndex = 33;
            this.AuthWinBtn.Text = "Authorization";
            this.AuthWinBtn.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.AuthWinBtn);
            this.Controls.Add(this.IronLineWeightLabel);
            this.Controls.Add(this.IronLineWeight);
            this.Controls.Add(this.IronColorLabel);
            this.Controls.Add(this.IronColor);
            this.Controls.Add(this.MeetingCircleRadius);
            this.Controls.Add(this.MeetingCircleRadiusLabel);
            this.Controls.Add(this.MaxBarLength);
            this.Controls.Add(this.MaxBarLengthLabel);
            this.Controls.Add(this.TextEditorBtn);
            this.Controls.Add(this.BarPolySpace);
            this.Controls.Add(this.BarPolySpaceLabel);
            this.Controls.Add(this.Diameter);
            this.Controls.Add(this.DiameterLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FontSize);
            this.Controls.Add(this.FontSizeLabel);
            this.Controls.Add(this.ArrowBlockingLineLength);
            this.Controls.Add(this.ArrowBlockingLineLengthLabel);
            this.Controls.Add(this.ArrowSize);
            this.Controls.Add(this.arrowSizelabel);
            this.Controls.Add(this.EarLength);
            this.Controls.Add(this.earLabel);
            this.Controls.Add(this.withEar);
            this.Controls.Add(this.SpacingInput);
            this.Controls.Add(this.spacingLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.drawHorizontal);
            this.Controls.Add(this.drawVertical);
            this.Name = "MainWindow";
            this.Text = "HamzaCAD Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.CheckBox drawVertical;
        private System.Windows.Forms.CheckBox drawHorizontal;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label spacingLabel;
        private System.Windows.Forms.MaskedTextBox SpacingInput;
        private System.Windows.Forms.CheckBox withEar;
        private System.Windows.Forms.Label earLabel;
        private System.Windows.Forms.MaskedTextBox EarLength;
        private System.Windows.Forms.Label arrowSizelabel;
        private System.Windows.Forms.MaskedTextBox ArrowSize;
        private System.Windows.Forms.Label ArrowBlockingLineLengthLabel;
        private System.Windows.Forms.MaskedTextBox ArrowBlockingLineLength;
        private System.Windows.Forms.Label FontSizeLabel;
        private System.Windows.Forms.MaskedTextBox FontSize;
        private System.Windows.Forms.RadioButton Eng;
        private System.Windows.Forms.RadioButton Heb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton TopBars;
        private System.Windows.Forms.RadioButton BottomBars;
        private System.Windows.Forms.Label DiameterLabel;
        private System.Windows.Forms.MaskedTextBox Diameter;
        private System.Windows.Forms.MaskedTextBox BarPolySpace;
        private System.Windows.Forms.Label BarPolySpaceLabel;
        private System.Windows.Forms.Button TextEditorBtn;
        private System.Windows.Forms.MaskedTextBox MaxBarLength;
        private System.Windows.Forms.Label MaxBarLengthLabel;
        private System.Windows.Forms.MaskedTextBox MeetingCircleRadius;
        private System.Windows.Forms.Label MeetingCircleRadiusLabel;
        private System.Windows.Forms.ComboBox IronColor;
        private System.Windows.Forms.Label IronColorLabel;
        private System.Windows.Forms.ComboBox IronLineWeight;
        private System.Windows.Forms.Label IronLineWeightLabel;
        private System.Windows.Forms.Button AuthWinBtn;
    }
}