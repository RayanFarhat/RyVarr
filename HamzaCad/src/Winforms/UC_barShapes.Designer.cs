﻿namespace HamzaCad.src.Winforms
{
    partial class UC_barShapes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarShapesPanelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.shapeWithLetters = new System.Windows.Forms.Panel();
            this.Bexample = new System.Windows.Forms.Label();
            this.Aexample = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.MaskedTextBox();
            this.ALabel = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.MaskedTextBox();
            this.BLabel = new System.Windows.Forms.Label();
            this.shapeWithLetters.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarShapesPanelContainer
            // 
            this.BarShapesPanelContainer.Location = new System.Drawing.Point(3, 3);
            this.BarShapesPanelContainer.Name = "BarShapesPanelContainer";
            this.BarShapesPanelContainer.Size = new System.Drawing.Size(320, 439);
            this.BarShapesPanelContainer.TabIndex = 1;
            // 
            // shapeWithLetters
            // 
            this.shapeWithLetters.Controls.Add(this.Bexample);
            this.shapeWithLetters.Location = new System.Drawing.Point(971, 32);
            this.shapeWithLetters.Name = "shapeWithLetters";
            this.shapeWithLetters.Size = new System.Drawing.Size(200, 100);
            this.shapeWithLetters.TabIndex = 2;
            // 
            // Bexample
            // 
            this.Bexample.AutoSize = true;
            this.Bexample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bexample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bexample.Location = new System.Drawing.Point(131, -5);
            this.Bexample.Name = "Bexample";
            this.Bexample.Size = new System.Drawing.Size(26, 25);
            this.Bexample.TabIndex = 0;
            this.Bexample.Text = "B";
            // 
            // Aexample
            // 
            this.Aexample.AutoSize = true;
            this.Aexample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aexample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aexample.Location = new System.Drawing.Point(1155, 70);
            this.Aexample.Name = "Aexample";
            this.Aexample.Size = new System.Drawing.Size(27, 25);
            this.Aexample.TabIndex = 1;
            this.Aexample.Text = "A";
            // 
            // A
            // 
            this.A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A.Location = new System.Drawing.Point(1066, 195);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 22);
            this.A.TabIndex = 37;
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(1019, 197);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(23, 16);
            this.ALabel.TabIndex = 36;
            this.ALabel.Text = "A=";
            // 
            // B
            // 
            this.B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B.Location = new System.Drawing.Point(1066, 269);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 22);
            this.B.TabIndex = 35;
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(1019, 271);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(23, 16);
            this.BLabel.TabIndex = 34;
            this.BLabel.Text = "B=";
            // 
            // UC_barShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.A);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.B);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.Aexample);
            this.Controls.Add(this.shapeWithLetters);
            this.Controls.Add(this.BarShapesPanelContainer);
            this.Name = "UC_barShapes";
            this.Size = new System.Drawing.Size(1200, 445);
            this.shapeWithLetters.ResumeLayout(false);
            this.shapeWithLetters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel BarShapesPanelContainer;
        private System.Windows.Forms.Panel shapeWithLetters;
        private System.Windows.Forms.Label Bexample;
        private System.Windows.Forms.Label Aexample;
        private System.Windows.Forms.MaskedTextBox A;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.MaskedTextBox B;
        private System.Windows.Forms.Label BLabel;
    }
}
