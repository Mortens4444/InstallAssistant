﻿namespace ProductInstaller._3
{
	partial class LicenseAgreementForm
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RtbLicenseAgreement = new System.Windows.Forms.RichTextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(385, 328);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(78, 27);
            this.BtnCancel.TabIndex = 5;
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
            this.BtnNext.TabIndex = 3;
            this.BtnNext.Text = "Accept";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutPanel.AutoScroll = true;
            this.LayoutPanel.ColumnCount = 1;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.Controls.Add(this.RtbLicenseAgreement, 0, 0);
            this.LayoutPanel.Location = new System.Drawing.Point(6, 41);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 1;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.Size = new System.Drawing.Size(457, 281);
            this.LayoutPanel.TabIndex = 4;
            // 
            // RtbLicenseAgreement
            // 
            this.RtbLicenseAgreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbLicenseAgreement.Location = new System.Drawing.Point(3, 3);
            this.RtbLicenseAgreement.Name = "RtbLicenseAgreement";
            this.RtbLicenseAgreement.Size = new System.Drawing.Size(451, 275);
            this.RtbLicenseAgreement.TabIndex = 0;
            this.RtbLicenseAgreement.Text = "";
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnBack.Location = new System.Drawing.Point(217, 328);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(78, 27);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please accept the license agreement to continoue the installation.";
            // 
            // LicenseAgreementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.LayoutPanel);
            this.MaximumSize = new System.Drawing.Size(485, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(485, 400);
            this.Name = "LicenseAgreementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup Wizard";
            this.LayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnNext;
		private System.Windows.Forms.TableLayoutPanel LayoutPanel;
		private System.Windows.Forms.Button BtnBack;
		private System.Windows.Forms.RichTextBox RtbLicenseAgreement;
		private System.Windows.Forms.Label label1;
	}
}