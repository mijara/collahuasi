namespace Learning
{
    partial class MultiLayerPerceptronModelPropertiesControl
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.optimizerComboBox = new System.Windows.Forms.ComboBox();
            this.alphaTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nnLayersListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nnAddLayerButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.27806F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.72194F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.optimizerComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.alphaTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(989, 398);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.label3.Size = new System.Drawing.Size(238, 290);
            this.label3.TabIndex = 4;
            this.label3.Text = "Capas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alpha";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Optimizador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optimizerComboBox
            // 
            this.optimizerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimizerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optimizerComboBox.FormattingEnabled = true;
            this.optimizerComboBox.Items.AddRange(new object[] {
            "lbfgs",
            "sgd",
            "adam"});
            this.optimizerComboBox.Location = new System.Drawing.Point(256, 6);
            this.optimizerComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.optimizerComboBox.Name = "optimizerComboBox";
            this.optimizerComboBox.Size = new System.Drawing.Size(727, 33);
            this.optimizerComboBox.TabIndex = 1;
            // 
            // alphaTextBox
            // 
            this.alphaTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alphaTextBox.Location = new System.Drawing.Point(256, 60);
            this.alphaTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.alphaTextBox.Name = "alphaTextBox";
            this.alphaTextBox.Size = new System.Drawing.Size(727, 31);
            this.alphaTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nnLayersListBox);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(256, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 278);
            this.panel1.TabIndex = 0;
            // 
            // nnLayersListBox
            // 
            this.nnLayersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nnLayersListBox.FormattingEnabled = true;
            this.nnLayersListBox.ItemHeight = 25;
            this.nnLayersListBox.Location = new System.Drawing.Point(0, 0);
            this.nnLayersListBox.Margin = new System.Windows.Forms.Padding(6);
            this.nnLayersListBox.Name = "nnLayersListBox";
            this.nnLayersListBox.Size = new System.Drawing.Size(657, 278);
            this.nnLayersListBox.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.nnAddLayerButton);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(657, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(70, 278);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // nnAddLayerButton
            // 
            this.nnAddLayerButton.Location = new System.Drawing.Point(6, 6);
            this.nnAddLayerButton.Margin = new System.Windows.Forms.Padding(6);
            this.nnAddLayerButton.Name = "nnAddLayerButton";
            this.nnAddLayerButton.Size = new System.Drawing.Size(58, 44);
            this.nnAddLayerButton.TabIndex = 7;
            this.nnAddLayerButton.Text = " +";
            this.nnAddLayerButton.UseVisualStyleBackColor = true;
            this.nnAddLayerButton.Click += new System.EventHandler(this.nnAddLayerButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.nnRemoveLayerButton_Click);
            // 
            // MultiLayerPerceptronModelPropertiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MultiLayerPerceptronModelPropertiesControl";
            this.Size = new System.Drawing.Size(989, 398);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox optimizerComboBox;
        private System.Windows.Forms.TextBox alphaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox nnLayersListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button nnAddLayerButton;
        private System.Windows.Forms.Button button2;
    }
}
