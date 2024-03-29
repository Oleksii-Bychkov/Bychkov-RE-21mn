﻿namespace cryptoXorRtf
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.xorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.pLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.pReverseLabel = new System.Windows.Forms.Label();
            this.keyReverseLabel = new System.Windows.Forms.Label();
            this.cReverseLabel = new System.Windows.Forms.Label();
            this.pReverseBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.keyReverseBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cReverseBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(164, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "P = ";
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(193, 52);
            this.pBox.Margin = new System.Windows.Forms.Padding(2);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(90, 20);
            this.pBox.TabIndex = 1;
            this.pBox.TextChanged += new System.EventHandler(this.OnPBoxChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(164, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key=";
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(194, 115);
            this.keyBox.Margin = new System.Windows.Forms.Padding(2);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(90, 20);
            this.keyBox.TabIndex = 3;
            this.keyBox.TextChanged += new System.EventHandler(this.OnKeyBoxChanged);
            // 
            // xorButton
            // 
            this.xorButton.Location = new System.Drawing.Point(290, 112);
            this.xorButton.Margin = new System.Windows.Forms.Padding(2);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(49, 24);
            this.xorButton.TabIndex = 4;
            this.xorButton.Text = "XOR";
            this.xorButton.UseMnemonic = false;
            this.xorButton.UseVisualStyleBackColor = true;
            this.xorButton.Click += new System.EventHandler(this.OnXorClick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(164, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "C=";
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(194, 187);
            this.cBox.Margin = new System.Windows.Forms.Padding(2);
            this.cBox.Name = "cBox";
            this.cBox.ReadOnly = true;
            this.cBox.Size = new System.Drawing.Size(90, 20);
            this.cBox.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(271, 211);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(88, 28);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Прибрати";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.OnClearClick);
            // 
            // pLabel
            // 
            this.pLabel.Location = new System.Drawing.Point(3, 6);
            this.pLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(279, 41);
            this.pLabel.TabIndex = 8;
            this.pLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // keyLabel
            // 
            this.keyLabel.Location = new System.Drawing.Point(3, 75);
            this.keyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(278, 37);
            this.keyLabel.TabIndex = 9;
            this.keyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cLabel
            // 
            this.cLabel.Location = new System.Drawing.Point(3, 135);
            this.cLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(279, 50);
            this.cLabel.TabIndex = 10;
            this.cLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pReverseLabel
            // 
            this.pReverseLabel.Location = new System.Drawing.Point(342, 139);
            this.pReverseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pReverseLabel.Name = "pReverseLabel";
            this.pReverseLabel.Size = new System.Drawing.Size(400, 46);
            this.pReverseLabel.TabIndex = 19;
            // 
            // keyReverseLabel
            // 
            this.keyReverseLabel.Location = new System.Drawing.Point(341, 75);
            this.keyReverseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.keyReverseLabel.Name = "keyReverseLabel";
            this.keyReverseLabel.Size = new System.Drawing.Size(401, 37);
            this.keyReverseLabel.TabIndex = 18;
            // 
            // cReverseLabel
            // 
            this.cReverseLabel.Location = new System.Drawing.Point(342, 6);
            this.cReverseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cReverseLabel.Name = "cReverseLabel";
            this.cReverseLabel.Size = new System.Drawing.Size(400, 44);
            this.cReverseLabel.TabIndex = 17;
            // 
            // pReverseBox
            // 
            this.pReverseBox.Location = new System.Drawing.Point(342, 187);
            this.pReverseBox.Margin = new System.Windows.Forms.Padding(2);
            this.pReverseBox.Name = "pReverseBox";
            this.pReverseBox.ReadOnly = true;
            this.pReverseBox.Size = new System.Drawing.Size(90, 20);
            this.pReverseBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(436, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "=C";
            // 
            // keyReverseBox
            // 
            this.keyReverseBox.Location = new System.Drawing.Point(343, 115);
            this.keyReverseBox.Margin = new System.Windows.Forms.Padding(2);
            this.keyReverseBox.Name = "keyReverseBox";
            this.keyReverseBox.Size = new System.Drawing.Size(90, 20);
            this.keyReverseBox.TabIndex = 14;
            this.keyReverseBox.TextChanged += new System.EventHandler(this.OnKeyReverseBoxChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(436, 115);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "=Key";
            // 
            // cReverseBox
            // 
            this.cReverseBox.Location = new System.Drawing.Point(342, 52);
            this.cReverseBox.Margin = new System.Windows.Forms.Padding(2);
            this.cReverseBox.Name = "cReverseBox";
            this.cReverseBox.Size = new System.Drawing.Size(90, 20);
            this.cReverseBox.TabIndex = 12;
            this.cReverseBox.TextChanged += new System.EventHandler(this.OnCReverseBoxChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(435, 187);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "=P";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 261);
            this.Controls.Add(this.pReverseLabel);
            this.Controls.Add(this.keyReverseLabel);
            this.Controls.Add(this.cReverseLabel);
            this.Controls.Add(this.pReverseBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.keyReverseBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cReverseBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xorButton);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label keyReverseLabel;

        private System.Windows.Forms.TextBox cReverseBox;
        private System.Windows.Forms.TextBox keyReverseBox;
        private System.Windows.Forms.TextBox pReverseBox;

        private System.Windows.Forms.Label pReverseLabel;
        private System.Windows.Forms.Label cReverseLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label cLabel;

        private System.Windows.Forms.Button clearButton;


        private System.Windows.Forms.TextBox keyBox;

        private System.Windows.Forms.TextBox pBox;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cBox;

        private System.Windows.Forms.Button xorButton;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}