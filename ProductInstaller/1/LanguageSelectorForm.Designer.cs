namespace ProductInstaller._1
{
	partial class LanguageSelectorForm
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
			this.LvLanguages = new System.Windows.Forms.ListView();
			this.LblChooseLanguage = new System.Windows.Forms.Label();
			this.PbVerticalLogo = new System.Windows.Forms.PictureBox();
			this.LayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbVerticalLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
			this.BtnNext.Text = "Next";
			this.BtnNext.UseVisualStyleBackColor = true;
			// 
			// LayoutPanel
			// 
			this.LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LayoutPanel.AutoScroll = true;
			this.LayoutPanel.ColumnCount = 2;
			this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
			this.LayoutPanel.Controls.Add(this.LvLanguages, 1, 0);
			this.LayoutPanel.Controls.Add(this.PbVerticalLogo, 0, 0);
			this.LayoutPanel.Location = new System.Drawing.Point(6, 41);
			this.LayoutPanel.Name = "LayoutPanel";
			this.LayoutPanel.RowCount = 1;
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutPanel.Size = new System.Drawing.Size(457, 281);
			this.LayoutPanel.TabIndex = 4;
			// 
			// LvLanguages
			// 
			this.LvLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LvLanguages.FullRowSelect = true;
			this.LvLanguages.HideSelection = false;
			this.LvLanguages.Location = new System.Drawing.Point(127, 3);
			this.LvLanguages.Name = "LvLanguages";
			this.LvLanguages.Size = new System.Drawing.Size(327, 275);
			this.LvLanguages.TabIndex = 0;
			this.LvLanguages.UseCompatibleStateImageBehavior = false;
			this.LvLanguages.View = System.Windows.Forms.View.List;
			this.LvLanguages.SelectedIndexChanged += new System.EventHandler(this.LvLanguages_SelectedIndexChanged);
			// 
			// LblChooseLanguage
			// 
			this.LblChooseLanguage.AutoSize = true;
			this.LblChooseLanguage.Location = new System.Drawing.Point(3, 15);
			this.LblChooseLanguage.Name = "LblChooseLanguage";
			this.LblChooseLanguage.Size = new System.Drawing.Size(204, 13);
			this.LblChooseLanguage.TabIndex = 6;
			this.LblChooseLanguage.Text = "Please choose a language for the installer";
			// 
			// PbVerticalLogo
			// 
			this.PbVerticalLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PbVerticalLogo.Image = global::ProductInstaller.Properties.Resources.VerticalLogo;
			this.PbVerticalLogo.Location = new System.Drawing.Point(3, 3);
			this.PbVerticalLogo.Name = "PbVerticalLogo";
			this.PbVerticalLogo.Size = new System.Drawing.Size(118, 275);
			this.PbVerticalLogo.TabIndex = 1;
			this.PbVerticalLogo.TabStop = false;
			// 
			// LanguageSelectorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 361);
			this.Controls.Add(this.LblChooseLanguage);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnNext);
			this.Controls.Add(this.LayoutPanel);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(485, 400);
			this.MinimumSize = new System.Drawing.Size(485, 400);
			this.Name = "LanguageSelectorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Setup Wizard";
			this.LayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PbVerticalLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnNext;
		private System.Windows.Forms.TableLayoutPanel LayoutPanel;
		private System.Windows.Forms.ListView LvLanguages;
		private System.Windows.Forms.Label LblChooseLanguage;
		private System.Windows.Forms.PictureBox PbVerticalLogo;
	}
}