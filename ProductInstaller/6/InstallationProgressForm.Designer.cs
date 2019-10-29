namespace ProductInstaller._6
{
	partial class InstallationProgressForm
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
			this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.LblInstalling = new System.Windows.Forms.Label();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.LblPleaseWait = new System.Windows.Forms.Label();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.LayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// LayoutPanel
			// 
			this.LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LayoutPanel.AutoScroll = true;
			this.LayoutPanel.ColumnCount = 1;
			this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.LayoutPanel.Controls.Add(this.ProgressBar, 0, 2);
			this.LayoutPanel.Controls.Add(this.LblPleaseWait, 0, 0);
			this.LayoutPanel.Location = new System.Drawing.Point(6, 41);
			this.LayoutPanel.Name = "LayoutPanel";
			this.LayoutPanel.RowCount = 3;
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutPanel.Size = new System.Drawing.Size(457, 281);
			this.LayoutPanel.TabIndex = 5;
			// 
			// LblInstalling
			// 
			this.LblInstalling.AutoSize = true;
			this.LblInstalling.Location = new System.Drawing.Point(6, 13);
			this.LblInstalling.Name = "LblInstalling";
			this.LblInstalling.Size = new System.Drawing.Size(48, 13);
			this.LblInstalling.TabIndex = 0;
			this.LblInstalling.Text = "Installing";
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnCancel.Location = new System.Drawing.Point(385, 328);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(78, 27);
			this.BtnCancel.TabIndex = 8;
			this.BtnCancel.Text = "Cancel";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// LblPleaseWait
			// 
			this.LblPleaseWait.AutoSize = true;
			this.LblPleaseWait.Location = new System.Drawing.Point(3, 0);
			this.LblPleaseWait.Name = "LblPleaseWait";
			this.LblPleaseWait.Size = new System.Drawing.Size(250, 13);
			this.LblPleaseWait.TabIndex = 0;
			this.LblPleaseWait.Text = "Please wait while {ProductName}  is being installed.";
			// 
			// ProgressBar
			// 
			this.ProgressBar.Location = new System.Drawing.Point(3, 36);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(451, 23);
			this.ProgressBar.TabIndex = 4;
			// 
			// InstallationProgressForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.BtnCancel;
			this.ClientSize = new System.Drawing.Size(469, 361);
			this.Controls.Add(this.LblInstalling);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.LayoutPanel);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(485, 400);
			this.MinimumSize = new System.Drawing.Size(485, 400);
			this.Name = "InstallationProgressForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{InstallerTitle} Setup";
			this.LayoutPanel.ResumeLayout(false);
			this.LayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel LayoutPanel;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Label LblInstalling;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.Label LblPleaseWait;
	}
}