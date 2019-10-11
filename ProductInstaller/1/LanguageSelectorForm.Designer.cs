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
            this.PbVerticalLogo = new System.Windows.Forms.PictureBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.LblChooseLanguage = new System.Windows.Forms.Label();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.LvLanguages = new System.Windows.Forms.ListView();
            this.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbVerticalLogo)).BeginInit();
            this.Panel.SuspendLayout();
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
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
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
            this.LayoutPanel.Location = new System.Drawing.Point(6, 41);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 1;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 394F));
            this.LayoutPanel.Size = new System.Drawing.Size(457, 281);
            this.LayoutPanel.TabIndex = 4;
            // 
            // PbVerticalLogo
            // 
            this.PbVerticalLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbVerticalLogo.Image = global::ProductInstaller.Properties.Resources.VerticalLogo;
            this.PbVerticalLogo.Location = new System.Drawing.Point(3, 3);
            this.PbVerticalLogo.Name = "PbVerticalLogo";
            this.PbVerticalLogo.Size = new System.Drawing.Size(158, 275);
            this.PbVerticalLogo.TabIndex = 1;
            this.PbVerticalLogo.TabStop = false;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.LblChooseLanguage);
            this.Panel.Controls.Add(this.LblWelcome);
            this.Panel.Controls.Add(this.LvLanguages);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(167, 3);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(287, 275);
            this.Panel.TabIndex = 2;
            // 
            // LblChooseLanguage
            // 
            this.LblChooseLanguage.AutoSize = true;
            this.LblChooseLanguage.Location = new System.Drawing.Point(3, 93);
            this.LblChooseLanguage.Name = "LblChooseLanguage";
            this.LblChooseLanguage.Size = new System.Drawing.Size(228, 13);
            this.LblChooseLanguage.TabIndex = 6;
            this.LblChooseLanguage.Text = "Please select a language for the install process";
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
            this.LblWelcome.Text = "Welcome to the {0} Setup Wizard";
            this.LblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LvLanguages
            // 
            this.LvLanguages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LvLanguages.FullRowSelect = true;
            this.LvLanguages.HideSelection = false;
            this.LvLanguages.Location = new System.Drawing.Point(0, 123);
            this.LvLanguages.Name = "LvLanguages";
            this.LvLanguages.Size = new System.Drawing.Size(287, 152);
            this.LvLanguages.TabIndex = 1;
            this.LvLanguages.UseCompatibleStateImageBehavior = false;
            this.LvLanguages.View = System.Windows.Forms.View.List;
            this.LvLanguages.SelectedIndexChanged += new System.EventHandler(this.LvLanguages_SelectedIndexChanged);
            // 
            // LanguageSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 361);
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
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnNext;
		private System.Windows.Forms.TableLayoutPanel LayoutPanel;
		private System.Windows.Forms.Label LblChooseLanguage;
        private System.Windows.Forms.PictureBox PbVerticalLogo;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.ListView LvLanguages;
        private System.Windows.Forms.Label LblWelcome;
    }
}