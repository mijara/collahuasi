namespace Learning
{
    partial class ModelCreator
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
            this.containerTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.algorithmComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.saveModelButton = new System.Windows.Forms.Button();
            this.propertiesPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.modelNameTextBox = new System.Windows.Forms.TextBox();
            this.containerTableLayout.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerTableLayout
            // 
            this.containerTableLayout.ColumnCount = 1;
            this.containerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerTableLayout.Controls.Add(this.groupBox1, 0, 0);
            this.containerTableLayout.Controls.Add(this.groupBox2, 0, 1);
            this.containerTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerTableLayout.Location = new System.Drawing.Point(0, 0);
            this.containerTableLayout.Margin = new System.Windows.Forms.Padding(6);
            this.containerTableLayout.Name = "containerTableLayout";
            this.containerTableLayout.RowCount = 2;
            this.containerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.containerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerTableLayout.Size = new System.Drawing.Size(1023, 290);
            this.containerTableLayout.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.algorithmComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1011, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algoritmo";
            // 
            // algorithmComboBox
            // 
            this.algorithmComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.algorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmComboBox.FormattingEnabled = true;
            this.algorithmComboBox.Location = new System.Drawing.Point(6, 30);
            this.algorithmComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.algorithmComboBox.Name = "algorithmComboBox";
            this.algorithmComboBox.Size = new System.Drawing.Size(999, 33);
            this.algorithmComboBox.TabIndex = 0;
            this.algorithmComboBox.SelectedIndexChanged += new System.EventHandler(this.algorithmComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.mainTableLayout);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(6, 100);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1011, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Propiedades";
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.AutoSize = true;
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 746F));
            this.mainTableLayout.Controls.Add(this.saveModelButton, 1, 2);
            this.mainTableLayout.Controls.Add(this.propertiesPanel, 0, 1);
            this.mainTableLayout.Controls.Add(this.label1, 0, 0);
            this.mainTableLayout.Controls.Add(this.modelNameTextBox, 1, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTableLayout.Location = new System.Drawing.Point(6, 30);
            this.mainTableLayout.Margin = new System.Windows.Forms.Padding(6);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 3;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.mainTableLayout.Size = new System.Drawing.Size(999, 152);
            this.mainTableLayout.TabIndex = 0;
            // 
            // saveModelButton
            // 
            this.saveModelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveModelButton.Location = new System.Drawing.Point(259, 91);
            this.saveModelButton.Margin = new System.Windows.Forms.Padding(6);
            this.saveModelButton.Name = "saveModelButton";
            this.saveModelButton.Size = new System.Drawing.Size(734, 55);
            this.saveModelButton.TabIndex = 8;
            this.saveModelButton.Text = "Guardar Modelo";
            this.saveModelButton.UseVisualStyleBackColor = true;
            this.saveModelButton.Click += new System.EventHandler(this.saveModelButton_Click);
            // 
            // propertiesPanel
            // 
            this.propertiesPanel.AutoSize = true;
            this.mainTableLayout.SetColumnSpan(this.propertiesPanel, 2);
            this.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesPanel.Location = new System.Drawing.Point(6, 55);
            this.propertiesPanel.Margin = new System.Windows.Forms.Padding(6);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.Padding = new System.Windows.Forms.Padding(12);
            this.propertiesPanel.Size = new System.Drawing.Size(987, 24);
            this.propertiesPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(12);
            this.label1.Size = new System.Drawing.Size(111, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // modelNameTextBox
            // 
            this.modelNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelNameTextBox.Location = new System.Drawing.Point(259, 6);
            this.modelNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.modelNameTextBox.Name = "modelNameTextBox";
            this.modelNameTextBox.Size = new System.Drawing.Size(734, 31);
            this.modelNameTextBox.TabIndex = 12;
            // 
            // ModelCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1023, 290);
            this.Controls.Add(this.containerTableLayout);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ModelCreator";
            this.Text = "Nuevo Modelo";
            this.containerTableLayout.ResumeLayout(false);
            this.containerTableLayout.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mainTableLayout.ResumeLayout(false);
            this.mainTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel containerTableLayout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox algorithmComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.Button saveModelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modelNameTextBox;
        private System.Windows.Forms.Panel propertiesPanel;
    }
}