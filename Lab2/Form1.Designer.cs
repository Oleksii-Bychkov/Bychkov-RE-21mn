namespace cryptoXorRtf
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
            this.label1 = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.xorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "P = ";
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(65, 46);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(118, 22);
            this.pBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key=";
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(65, 71);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(118, 22);
            this.keyBox.TabIndex = 3;
            // 
            // xorButton
            // 
            this.xorButton.Location = new System.Drawing.Point(202, 58);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(65, 26);
            this.xorButton.TabIndex = 4;
            this.xorButton.Text = "XOR";
            this.xorButton.UseMnemonic = false;
            this.xorButton.UseVisualStyleBackColor = true;
            this.xorButton.Click += new System.EventHandler(this.OnXorClick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "C=";
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(65, 99);
            this.cBox.Name = "cBox";
            this.cBox.ReadOnly = true;
            this.cBox.Size = new System.Drawing.Size(118, 22);
            this.cBox.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(65, 132);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(117, 34);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Прибрати";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.OnClearClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 211);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xorButton);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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