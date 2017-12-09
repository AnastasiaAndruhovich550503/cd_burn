namespace CDBurn
{
    partial class BurnProgressWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurnProgressWindow));
            this.burnProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // burnProgressBar
            // 
            this.burnProgressBar.Location = new System.Drawing.Point(12, 25);
            this.burnProgressBar.Name = "burnProgressBar";
            this.burnProgressBar.Size = new System.Drawing.Size(583, 23);
            this.burnProgressBar.TabIndex = 0;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(9, 9);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(103, 13);
            this.progressLabel.TabIndex = 1;
            this.progressLabel.Text = "Burning in process...";
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipTitle = "CDBurn notification";
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "CDBurn";
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIconMouseClick);
            // 
            // BurnProgressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 62);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.burnProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BurnProgressWindow";
            this.Text = "Burn Progress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BurnProgressWindowFormClosing);
            this.Resize += new System.EventHandler(this.BurnProgressWindowResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar burnProgressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.NotifyIcon trayIcon;
    }
}