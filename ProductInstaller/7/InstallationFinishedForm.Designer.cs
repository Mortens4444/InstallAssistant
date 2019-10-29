namespace ProductInstaller._7
{
	partial class InstallationFinishedForm
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
			this.BtnFinish = new System.Windows.Forms.Button();
			this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.LblInstallationCompleted = new System.Windows.Forms.Label();
			this.LblClickFinish = new System.Windows.Forms.Label();
			this.LayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnFinish
			// 
			this.BtnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.BtnFinish.Location = new System.Drawing.Point(385, 328);
			this.BtnFinish.Name = "BtnFinish";
			this.BtnFinish.Size = new System.Drawing.Size(78, 27);
			this.BtnFinish.TabIndex = 3;
			this.BtnFinish.Text = "Finish";
			this.BtnFinish.UseVisualStyleBackColor = true;
			// 
			// LayoutPanel
			// 
			this.LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LayoutPanel.AutoScroll = true;
			this.LayoutPanel.ColumnCount = 1;
			this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.LayoutPanel.Controls.Add(this.LblClickFinish, 0, 0);
			this.LayoutPanel.Location = new System.Drawing.Point(6, 41);
			this.LayoutPanel.Name = "LayoutPanel";
			this.LayoutPanel.RowCount = 2;
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutPanel.Size = new System.Drawing.Size(457, 281);
			this.LayoutPanel.TabIndex = 4;
			// 
			// LblInstallationCompleted
			// 
			this.LblInstallationCompleted.AutoSize = true;
			this.LblInstallationCompleted.Location = new System.Drawing.Point(6, 13);
			this.LblInstallationCompleted.Name = "LblInstallationCompleted";
			this.LblInstallationCompleted.Size = new System.Drawing.Size(109, 13);
			this.LblInstallationCompleted.TabIndex = 5;
			this.LblInstallationCompleted.Text = "Installation completed";
			// 
			// LblClickFinish
			// 
			this.LblClickFinish.AutoSize = true;
			this.LblClickFinish.Location = new System.Drawing.Point(3, 0);
			this.LblClickFinish.Name = "LblClickFinish";
			this.LblClickFinish.Size = new System.Drawing.Size(130, 13);
			this.LblClickFinish.TabIndex = 0;
			this.LblClickFinish.Text = "Click \"Finish\" to exit setup";
			// 
			// InstallationFinishedForm
			// 
			this.AcceptButton = this.BtnFinish;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 361);
			this.Controls.Add(this.LblInstallationCompleted);
			this.Controls.Add(this.BtnFinish);
			this.Controls.Add(this.LayoutPanel);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(485, 400);
			this.MinimumSize = new System.Drawing.Size(485, 400);
			this.Name = "InstallationFinishedForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{InstallerTitle} Setup";
			this.LayoutPanel.ResumeLayout(false);
			this.LayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button BtnFinish;
		private System.Windows.Forms.TableLayoutPanel LayoutPanel;
		private System.Windows.Forms.Label LblClickFinish;
		private System.Windows.Forms.Label LblInstallationCompleted;
	}
}