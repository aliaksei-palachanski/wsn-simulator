namespace WsnSimulator.Forms
{
    partial class MainForm
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
            this.setupNetworkButton = new System.Windows.Forms.Button();
            this.xSizeLabel = new System.Windows.Forms.Label();
            this.xSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ySizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ySizeLabel = new System.Windows.Forms.Label();
            this.nodesCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nodesCountLabel = new System.Windows.Forms.Label();
            this.simulationPanel = new System.Windows.Forms.Panel();
            this.runOneStepButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // setupNetworkButton
            // 
            this.setupNetworkButton.Location = new System.Drawing.Point(41, 235);
            this.setupNetworkButton.Name = "setupNetworkButton";
            this.setupNetworkButton.Size = new System.Drawing.Size(120, 23);
            this.setupNetworkButton.TabIndex = 0;
            this.setupNetworkButton.Text = "Setup network";
            this.setupNetworkButton.UseVisualStyleBackColor = true;
            this.setupNetworkButton.Click += new System.EventHandler(this.setupNetworkButton_Click);
            // 
            // xSizeLabel
            // 
            this.xSizeLabel.AutoSize = true;
            this.xSizeLabel.Location = new System.Drawing.Point(38, 29);
            this.xSizeLabel.Name = "xSizeLabel";
            this.xSizeLabel.Size = new System.Drawing.Size(38, 13);
            this.xSizeLabel.TabIndex = 1;
            this.xSizeLabel.Text = "X size:";
            // 
            // xSizeNumericUpDown
            // 
            this.xSizeNumericUpDown.Location = new System.Drawing.Point(41, 55);
            this.xSizeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xSizeNumericUpDown.Name = "xSizeNumericUpDown";
            this.xSizeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.xSizeNumericUpDown.TabIndex = 2;
            this.xSizeNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ySizeNumericUpDown
            // 
            this.ySizeNumericUpDown.Location = new System.Drawing.Point(41, 120);
            this.ySizeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ySizeNumericUpDown.Name = "ySizeNumericUpDown";
            this.ySizeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ySizeNumericUpDown.TabIndex = 4;
            this.ySizeNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ySizeLabel
            // 
            this.ySizeLabel.AutoSize = true;
            this.ySizeLabel.Location = new System.Drawing.Point(38, 94);
            this.ySizeLabel.Name = "ySizeLabel";
            this.ySizeLabel.Size = new System.Drawing.Size(38, 13);
            this.ySizeLabel.TabIndex = 3;
            this.ySizeLabel.Text = "X size:";
            // 
            // nodesCountNumericUpDown
            // 
            this.nodesCountNumericUpDown.Location = new System.Drawing.Point(41, 187);
            this.nodesCountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nodesCountNumericUpDown.Name = "nodesCountNumericUpDown";
            this.nodesCountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.nodesCountNumericUpDown.TabIndex = 6;
            this.nodesCountNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nodesCountLabel
            // 
            this.nodesCountLabel.AutoSize = true;
            this.nodesCountLabel.Location = new System.Drawing.Point(38, 161);
            this.nodesCountLabel.Name = "nodesCountLabel";
            this.nodesCountLabel.Size = new System.Drawing.Size(71, 13);
            this.nodesCountLabel.TabIndex = 5;
            this.nodesCountLabel.Text = "Nodes count:";
            // 
            // simulationPanel
            // 
            this.simulationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.simulationPanel.Location = new System.Drawing.Point(245, 29);
            this.simulationPanel.Name = "simulationPanel";
            this.simulationPanel.Size = new System.Drawing.Size(678, 378);
            this.simulationPanel.TabIndex = 7;
            // 
            // runOneStepButton
            // 
            this.runOneStepButton.Enabled = false;
            this.runOneStepButton.Location = new System.Drawing.Point(41, 273);
            this.runOneStepButton.Name = "runOneStepButton";
            this.runOneStepButton.Size = new System.Drawing.Size(120, 23);
            this.runOneStepButton.TabIndex = 8;
            this.runOneStepButton.Text = "Run one step";
            this.runOneStepButton.UseVisualStyleBackColor = true;
            this.runOneStepButton.Click += new System.EventHandler(this.runOneStepButton_Click);
            // 
            // runButton
            // 
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(41, 318);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(120, 23);
            this.runButton.TabIndex = 9;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 491);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.runOneStepButton);
            this.Controls.Add(this.simulationPanel);
            this.Controls.Add(this.nodesCountNumericUpDown);
            this.Controls.Add(this.nodesCountLabel);
            this.Controls.Add(this.ySizeNumericUpDown);
            this.Controls.Add(this.ySizeLabel);
            this.Controls.Add(this.xSizeNumericUpDown);
            this.Controls.Add(this.xSizeLabel);
            this.Controls.Add(this.setupNetworkButton);
            this.Name = "MainForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.xSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setupNetworkButton;
        private System.Windows.Forms.Label xSizeLabel;
        private System.Windows.Forms.NumericUpDown xSizeNumericUpDown;
        private System.Windows.Forms.NumericUpDown ySizeNumericUpDown;
        private System.Windows.Forms.Label ySizeLabel;
        private System.Windows.Forms.NumericUpDown nodesCountNumericUpDown;
        private System.Windows.Forms.Label nodesCountLabel;
        private System.Windows.Forms.Panel simulationPanel;
        private System.Windows.Forms.Button runOneStepButton;
        private System.Windows.Forms.Button runButton;
    }
}