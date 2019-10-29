namespace ProductInstaller._5
{
	partial class StartInstallForm
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.lblReadyToInstall = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
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
            this.LayoutPanel.Controls.Add(this.label2, 0, 0);
            this.LayoutPanel.Location = new System.Drawing.Point(6, 41);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 1;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutPanel.Size = new System.Drawing.Size(457, 281);
            this.LayoutPanel.TabIndex = 5;
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnBack.Location = new System.Drawing.Point(217, 328);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(78, 27);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
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
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnNext.Location = new System.Drawing.Point(301, 328);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(78, 27);
            this.BtnNext.TabIndex = 7;
            this.BtnNext.Text = "Install";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // lblReadyToInstall
            // 
            this.lblReadyToInstall.AutoSize = true;
            this.lblReadyToInstall.Location = new System.Drawing.Point(6, 13);
            this.lblReadyToInstall.Name = "lblReadyToInstall";
            this.lblReadyToInstall.Size = new System.Drawing.Size(80, 13);
            this.lblReadyToInstall.TabIndex = 10;
            this.lblReadyToInstall.Text = "Ready to Install";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(446, 26);
			this.label2.TabIndex = 0;
			this.label2.Text = "Click \"Install\" to begin the installation. If you want to review or change any of" +
    " your installation settings, click \"Back\". Click \"Cancel\" to exit the wizard.";
            // 
            // StartInstallForm
            // 
            this.AcceptButton = this.BtnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(469, 361);
            this.Controls.Add(this.lblReadyToInstall);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.LayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 400);
            this.MinimumSize = new System.Drawing.Size(485, 400);
            this.Name = "StartInstallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{InstallerTitle} Setup";
            this.LayoutPanel.ResumeLayout(false);
            this.LayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel LayoutPanel;
		private System.Windows.Forms.Button BtnBack;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnNext;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblReadyToInstall;
	}
}