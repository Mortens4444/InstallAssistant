namespace ProductInstaller._2
{
	partial class PrerequisitesForm
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
			this.PbVerticalLogo = new System.Windows.Forms.PictureBox();
			this.Panel = new System.Windows.Forms.Panel();
			this.LblChooseLanguage = new System.Windows.Forms.Label();
			this.LblWelcome = new System.Windows.Forms.Label();
			this.LvPrerequisites = new System.Windows.Forms.ListView();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.BtnNext = new System.Windows.Forms.Button();
			this.BtnBack = new System.Windows.Forms.Button();
			this.LayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbVerticalLogo)).BeginInit();
			this.Panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// LayoutPanel
			// 
			this.LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LayoutPanel.ColumnCount = 2;
			this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 293F));
			this.LayoutPanel.Controls.Add(this.PbVerticalLogo, 0, 0);
			this.LayoutPanel.Controls.Add(this.Panel, 1, 0);
			this.LayoutPanel.Location = new System.Drawing.Point(6, 2);
			this.LayoutPanel.Name = "LayoutPanel";
			this.LayoutPanel.RowCount = 1;
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
			this.LayoutPanel.Size = new System.Drawing.Size(457, 320);
			this.LayoutPanel.TabIndex = 5;
			// 
			// PbVerticalLogo
			// 
			this.PbVerticalLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PbVerticalLogo.Image = global::ProductInstaller.Properties.Resources.VerticalLogo;
			this.PbVerticalLogo.Location = new System.Drawing.Point(3, 3);
			this.PbVerticalLogo.Name = "PbVerticalLogo";
			this.PbVerticalLogo.Size = new System.Drawing.Size(158, 314);
			this.PbVerticalLogo.TabIndex = 1;
			this.PbVerticalLogo.TabStop = false;
			// 
			// Panel
			// 
			this.Panel.Controls.Add(this.LblChooseLanguage);
			this.Panel.Controls.Add(this.LblWelcome);
			this.Panel.Controls.Add(this.LvPrerequisites);
			this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel.Location = new System.Drawing.Point(167, 3);
			this.Panel.Name = "Panel";
			this.Panel.Size = new System.Drawing.Size(287, 314);
			this.Panel.TabIndex = 2;
			// 
			// LblChooseLanguage
			// 
			this.LblChooseLanguage.AutoSize = true;
			this.LblChooseLanguage.Location = new System.Drawing.Point(3, 93);
			this.LblChooseLanguage.MaximumSize = new System.Drawing.Size(280, 0);
			this.LblChooseLanguage.Name = "LblChooseLanguage";
			this.LblChooseLanguage.Size = new System.Drawing.Size(264, 39);
			this.LblChooseLanguage.TabIndex = 6;
			this.LblChooseLanguage.Text = "The Setup Wizard will install {ProductName} and the following prerequisites on yo" +
    "ur computer. Click Next to continue or Cancel to exit the Setup Wizard.";
			// 
			// LblWelcome
			// 
			this.LblWelcome.BackColor = System.Drawing.Color.Transparent;
			this.LblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
			this.LblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblWelcome.Location = new System.Drawing.Point(0, 0);
			this.LblWelcome.Name = "LblWelcome";
			this.LblWelcome.Size = new System.Drawing.Size(287, 93);
			this.LblWelcome.TabIndex = 3;
			this.LblWelcome.Text = "Welcome to the {ProductName} Setup Wizard";
			this.LblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LvPrerequisites
			// 
			this.LvPrerequisites.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.LvPrerequisites.FullRowSelect = true;
			this.LvPrerequisites.HideSelection = false;
			this.LvPrerequisites.Location = new System.Drawing.Point(0, 162);
			this.LvPrerequisites.MultiSelect = false;
			this.LvPrerequisites.Name = "LvPrerequisites";
			this.LvPrerequisites.Size = new System.Drawing.Size(287, 152);
			this.LvPrerequisites.TabIndex = 1;
			this.LvPrerequisites.UseCompatibleStateImageBehavior = false;
			this.LvPrerequisites.View = System.Windows.Forms.View.List;
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.Location = new System.Drawing.Point(385, 328);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(78, 27);
			this.BtnCancel.TabIndex = 7;
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
			this.BtnNext.TabIndex = 6;
			this.BtnNext.Text = "Next";
			this.BtnNext.UseVisualStyleBackColor = true;
			// 
			// BtnBack
			// 
			this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnBack.DialogResult = System.Windows.Forms.DialogResult.No;
			this.BtnBack.Location = new System.Drawing.Point(217, 328);
			this.BtnBack.Name = "BtnBack";
			this.BtnBack.Size = new System.Drawing.Size(78, 27);
			this.BtnBack.TabIndex = 8;
			this.BtnBack.Text = "Back";
			this.BtnBack.UseVisualStyleBackColor = true;
			// 
			// PrerequisitesForm
			// 
			this.AcceptButton = this.BtnNext;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.BtnCancel;
			this.ClientSize = new System.Drawing.Size(469, 361);
			this.Controls.Add(this.BtnBack);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnNext);
			this.Controls.Add(this.LayoutPanel);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(485, 400);
			this.MinimumSize = new System.Drawing.Size(485, 400);
			this.Name = "PrerequisitesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "{InstallerTitle} Setup";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrerequisitesForm_FormClosing);
			this.LayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PbVerticalLogo)).EndInit();
			this.Panel.ResumeLayout(false);
			this.Panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel LayoutPanel;
		private System.Windows.Forms.PictureBox PbVerticalLogo;
		private System.Windows.Forms.Panel Panel;
		private System.Windows.Forms.Label LblChooseLanguage;
		private System.Windows.Forms.Label LblWelcome;
		private System.Windows.Forms.ListView LvPrerequisites;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnNext;
		private System.Windows.Forms.Button BtnBack;
	}
}