namespace Learning
{
    partial class TrainingDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.titleTextBox = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.trainingBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CausesValidation = false;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.titleTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.146341F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.85366F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 348);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.outputRichTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(550, 274);
            this.outputRichTextBox.TabIndex = 2;
            this.outputRichTextBox.Text = "";
            // 
            // titleTextBox
            // 
            this.titleTextBox.AutoSize = true;
            this.titleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTextBox.Location = new System.Drawing.Point(13, 10);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(444, 29);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.Text = "Entrenando Modelo: Python MLP";
            this.titleTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(463, 13);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // trainingBackgroundWorker
            // 
            this.trainingBackgroundWorker.WorkerReportsProgress = true;
            this.trainingBackgroundWorker.WorkerSupportsCancellation = true;
            this.trainingBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.trainingBackgroundWorker_DoWork);
            this.trainingBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.trainingBackgroundWorker_ProgressChanged);
            this.trainingBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.trainingBackgroundWorker_RunWorkerCompleted);
            // 
            // TrainingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 348);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TrainingDialog";
            this.Text = "Entrenando Modelo...";
            this.Load += new System.EventHandler(this.TrainingDialog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Label titleTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.ComponentModel.BackgroundWorker trainingBackgroundWorker;
    }
}