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
			this.BtnExit = new System.Windows.Forms.Button();
			this.BtnFinish = new System.Windows.Forms.Button();
			this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.SuspendLayout();
			// 
			// BtnExit
			// 
			this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnExit.Location = new System.Drawing.Point(385, 328);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(78, 27);
			this.BtnExit.TabIndex = 5;
			this.BtnExit.Text = "Exit";
			this.BtnExit.UseVisualStyleBackColor = true;
			// 
			// BtnFinish
			// 
			this.BtnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.BtnFinish.Location = new System.Drawing.Point(301, 328);
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
			this.LayoutPanel.Location = new System.Drawing.Point(6, 41);
			this.LayoutPanel.Name = "LayoutPanel";
			this.LayoutPanel.RowCount = 1;
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutPanel.Size = new System.Drawing.Size(457, 281);
			this.LayoutPanel.TabIndex = 4;
			// 
			// InstallationFinishedForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 361);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.BtnFinish);
			this.Controls.Add(this.LayoutPanel);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(485, 400);
			this.MinimumSize = new System.Drawing.Size(485, 400);
			this.Name = "InstallationFinishedForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "InstallationFinishedForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.Button BtnFinish;
		private System.Windows.Forms.TableLayoutPanel LayoutPanel;
	}
}