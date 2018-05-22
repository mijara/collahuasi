namespace Learning
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.modelsListBox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.datasetPathTextBox = new System.Windows.Forms.TextBox();
            this.datasetSelectButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.featuresCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.targetComboBoxList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.trainModelButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.trainingPercentageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.resumeGroupBox = new System.Windows.Forms.GroupBox();
            this.resumePanel = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.predictionsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datasetOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingPercentageNumericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.resumeGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 525);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 525);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.modelsListBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 525);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // modelsListBox
            // 
            this.modelsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelsListBox.FormattingEnabled = true;
            this.modelsListBox.Location = new System.Drawing.Point(3, 3);
            this.modelsListBox.Name = "modelsListBox";
            this.modelsListBox.Size = new System.Drawing.Size(194, 476);
            this.modelsListBox.TabIndex = 1;
            this.modelsListBox.DoubleClick += new System.EventHandler(this.modelsListBox_DoubleClick);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Nuevo Modelo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 525);
            this.panel2.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.MinimumSize = new System.Drawing.Size(640, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(752, 525);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entrenamiento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 493);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dataset";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel2.Controls.Add(this.datasetPathTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.datasetSelectButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(726, 29);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // datasetPathTextBox
            // 
            this.datasetPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetPathTextBox.Location = new System.Drawing.Point(3, 3);
            this.datasetPathTextBox.Name = "datasetPathTextBox";
            this.datasetPathTextBox.ReadOnly = true;
            this.datasetPathTextBox.Size = new System.Drawing.Size(593, 20);
            this.datasetPathTextBox.TabIndex = 0;
            // 
            // datasetSelectButton
            // 
            this.datasetSelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasetSelectButton.Location = new System.Drawing.Point(602, 3);
            this.datasetSelectButton.Name = "datasetSelectButton";
            this.datasetSelectButton.Size = new System.Drawing.Size(121, 23);
            this.datasetSelectButton.TabIndex = 1;
            this.datasetSelectButton.Text = "Seleccionar archivo...";
            this.datasetSelectButton.UseVisualStyleBackColor = true;
            this.datasetSelectButton.Click += new System.EventHandler(this.datasetSelectButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(738, 403);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.featuresCheckBoxList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 348);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Features";
            // 
            // featuresCheckBoxList
            // 
            this.featuresCheckBoxList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.featuresCheckBoxList.CheckOnClick = true;
            this.featuresCheckBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featuresCheckBoxList.Location = new System.Drawing.Point(3, 16);
            this.featuresCheckBoxList.Name = "featuresCheckBoxList";
            this.featuresCheckBoxList.Size = new System.Drawing.Size(726, 329);
            this.featuresCheckBoxList.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.targetComboBoxList);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 43);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Target";
            // 
            // targetComboBoxList
            // 
            this.targetComboBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetComboBoxList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetComboBoxList.FormattingEnabled = true;
            this.targetComboBoxList.Location = new System.Drawing.Point(3, 16);
            this.targetComboBoxList.Name = "targetComboBoxList";
            this.targetComboBoxList.Size = new System.Drawing.Size(726, 21);
            this.targetComboBoxList.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.90909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09091F));
            this.tableLayoutPanel5.Controls.Add(this.trainModelButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 457);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(738, 36);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // trainModelButton
            // 
            this.trainModelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainModelButton.Location = new System.Drawing.Point(526, 3);
            this.trainModelButton.Name = "trainModelButton";
            this.trainModelButton.Size = new System.Drawing.Size(209, 30);
            this.trainModelButton.TabIndex = 5;
            this.trainModelButton.Text = "Entrenar Modelo";
            this.trainModelButton.UseVisualStyleBackColor = true;
            this.trainModelButton.Click += new System.EventHandler(this.trainModelButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.trainingPercentageNumericUpDown);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(517, 30);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porcentaje de Entrenamiento";
            // 
            // trainingPercentageNumericUpDown
            // 
            this.trainingPercentageNumericUpDown.Location = new System.Drawing.Point(168, 6);
            this.trainingPercentageNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.trainingPercentageNumericUpDown.Name = "trainingPercentageNumericUpDown";
            this.trainingPercentageNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.trainingPercentageNumericUpDown.TabIndex = 1;
            this.trainingPercentageNumericUpDown.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel6);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resultados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.resumeGroupBox, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(538, 493);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // resumeGroupBox
            // 
            this.resumeGroupBox.Controls.Add(this.resumePanel);
            this.resumeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resumeGroupBox.Location = new System.Drawing.Point(3, 3);
            this.resumeGroupBox.Name = "resumeGroupBox";
            this.resumeGroupBox.Size = new System.Drawing.Size(263, 240);
            this.resumeGroupBox.TabIndex = 0;
            this.resumeGroupBox.TabStop = false;
            this.resumeGroupBox.Text = "Resumen";
            // 
            // resumePanel
            // 
            this.resumePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resumePanel.Location = new System.Drawing.Point(3, 16);
            this.resumePanel.Margin = new System.Windows.Forms.Padding(2);
            this.resumePanel.Name = "resumePanel";
            this.resumePanel.Size = new System.Drawing.Size(257, 221);
            this.resumePanel.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(541, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 493);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Predicciones";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.predictionsListView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 474);
            this.panel4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 439);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Publicar Predicciones On-line";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // predictionsListView
            // 
            this.predictionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.predictionsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.predictionsListView.Location = new System.Drawing.Point(0, 0);
            this.predictionsListView.Name = "predictionsListView";
            this.predictionsListView.Size = new System.Drawing.Size(194, 474);
            this.predictionsListView.TabIndex = 1;
            this.predictionsListView.UseCompatibleStateImageBehavior = false;
            this.predictionsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Y";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "P";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Error";
            // 
            // datasetOpenFileDialog
            // 
            this.datasetOpenFileDialog.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(968, 564);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VSP-I";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingPercentageNumericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.resumeGroupBox.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListBox modelsListBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog datasetOpenFileDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox datasetPathTextBox;
        private System.Windows.Forms.Button datasetSelectButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox featuresCheckBoxList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox targetComboBoxList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button trainModelButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown trainingPercentageNumericUpDown;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox resumeGroupBox;
        private System.Windows.Forms.Panel resumePanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView predictionsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
    }
}

