namespace CDBurn
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addFileButton = new System.Windows.Forms.Button();
            this.cdDriverComboBox = new System.Windows.Forms.ComboBox();
            this.usedSpaceBar = new System.Windows.Forms.ProgressBar();
            this.burnButton = new System.Windows.Forms.Button();
            this.checkDiskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discTypeLabel = new System.Windows.Forms.Label();
            this.usedSpaceLabel = new System.Windows.Forms.Label();
            this.discSizeLabel = new System.Windows.Forms.Label();
            this.removeFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.Location = new System.Drawing.Point(12, 28);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(353, 264);
            this.filesListBox.TabIndex = 0;
            this.filesListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FilesListBoxMouseClick);
            this.filesListBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FilesListBoxFormat);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // addFileButton
            // 
            this.addFileButton.Enabled = false;
            this.addFileButton.Location = new System.Drawing.Point(12, 298);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(75, 23);
            this.addFileButton.TabIndex = 1;
            this.addFileButton.Text = "Add file(s)...";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.AddFileButtonClick);
            // 
            // cdDriverComboBox
            // 
            this.cdDriverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdDriverComboBox.FormattingEnabled = true;
            this.cdDriverComboBox.Location = new System.Drawing.Point(371, 28);
            this.cdDriverComboBox.Name = "cdDriverComboBox";
            this.cdDriverComboBox.Size = new System.Drawing.Size(213, 21);
            this.cdDriverComboBox.TabIndex = 2;
            this.cdDriverComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CdDriverComboBoxFormat);
            // 
            // usedSpaceBar
            // 
            this.usedSpaceBar.Location = new System.Drawing.Point(12, 12);
            this.usedSpaceBar.Name = "usedSpaceBar";
            this.usedSpaceBar.Size = new System.Drawing.Size(573, 10);
            this.usedSpaceBar.TabIndex = 3;
            // 
            // burnButton
            // 
            this.burnButton.Enabled = false;
            this.burnButton.Location = new System.Drawing.Point(509, 298);
            this.burnButton.Name = "burnButton";
            this.burnButton.Size = new System.Drawing.Size(75, 23);
            this.burnButton.TabIndex = 4;
            this.burnButton.Text = "Burn";
            this.burnButton.UseVisualStyleBackColor = true;
            this.burnButton.Click += new System.EventHandler(this.BurnButtonClick);
            // 
            // checkDiskButton
            // 
            this.checkDiskButton.Location = new System.Drawing.Point(371, 117);
            this.checkDiskButton.Name = "checkDiskButton";
            this.checkDiskButton.Size = new System.Drawing.Size(75, 23);
            this.checkDiskButton.TabIndex = 5;
            this.checkDiskButton.Text = "Check disk";
            this.checkDiskButton.UseVisualStyleBackColor = true;
            this.checkDiskButton.Click += new System.EventHandler(this.CheckDiskButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Disk type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Used space:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Disk size:";
            // 
            // discTypeLabel
            // 
            this.discTypeLabel.AutoSize = true;
            this.discTypeLabel.Location = new System.Drawing.Point(441, 56);
            this.discTypeLabel.Name = "discTypeLabel";
            this.discTypeLabel.Size = new System.Drawing.Size(33, 13);
            this.discTypeLabel.TabIndex = 9;
            this.discTypeLabel.Text = "N / A";
            // 
            // usedSpaceLabel
            // 
            this.usedSpaceLabel.AutoSize = true;
            this.usedSpaceLabel.Location = new System.Drawing.Point(441, 74);
            this.usedSpaceLabel.Name = "usedSpaceLabel";
            this.usedSpaceLabel.Size = new System.Drawing.Size(32, 13);
            this.usedSpaceLabel.TabIndex = 10;
            this.usedSpaceLabel.Text = "0 MB";
            // 
            // discSizeLabel
            // 
            this.discSizeLabel.AutoSize = true;
            this.discSizeLabel.Location = new System.Drawing.Point(441, 91);
            this.discSizeLabel.Name = "discSizeLabel";
            this.discSizeLabel.Size = new System.Drawing.Size(32, 13);
            this.discSizeLabel.TabIndex = 11;
            this.discSizeLabel.Text = "0 MB";
            // 
            // removeFileButton
            // 
            this.removeFileButton.Enabled = false;
            this.removeFileButton.Location = new System.Drawing.Point(94, 298);
            this.removeFileButton.Name = "removeFileButton";
            this.removeFileButton.Size = new System.Drawing.Size(75, 23);
            this.removeFileButton.TabIndex = 13;
            this.removeFileButton.Text = "Remove file";
            this.removeFileButton.UseVisualStyleBackColor = true;
            this.removeFileButton.Click += new System.EventHandler(this.RemoveFileButtonClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 330);
            this.Controls.Add(this.removeFileButton);
            this.Controls.Add(this.discSizeLabel);
            this.Controls.Add(this.usedSpaceLabel);
            this.Controls.Add(this.discTypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkDiskButton);
            this.Controls.Add(this.burnButton);
            this.Controls.Add(this.usedSpaceBar);
            this.Controls.Add(this.cdDriverComboBox);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.filesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "CDBurn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.ComboBox cdDriverComboBox;
        private System.Windows.Forms.ProgressBar usedSpaceBar;
        private System.Windows.Forms.Button burnButton;
        private System.Windows.Forms.Button checkDiskButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label discTypeLabel;
        private System.Windows.Forms.Label usedSpaceLabel;
        private System.Windows.Forms.Label discSizeLabel;
        private System.Windows.Forms.Button removeFileButton;
    }
}

