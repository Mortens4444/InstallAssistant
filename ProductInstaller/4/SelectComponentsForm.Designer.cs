﻿namespace ProductInstaller._4
{
    partial class SelectComponentsForm
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
			this.GroupBox = new System.Windows.Forms.GroupBox();
			this.Label = new System.Windows.Forms.Label();
			this.ComboBox = new System.Windows.Forms.ComboBox();
			this.BtnExit = new System.Windows.Forms.Button();
			this.BtnFinish = new System.Windows.Forms.Button();
			this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.BtnBack = new System.Windows.Forms.Button();
			this.GroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox
			// 
			this.GroupBox.Controls.Add(this.BtnBack);
			this.GroupBox.Controls.Add(this.Label);
			this.GroupBox.Controls.Add(this.ComboBox);
			this.GroupBox.Controls.Add(this.BtnExit);
			this.GroupBox.Controls.Add(this.BtnFinish);
			this.GroupBox.Controls.Add(this.LayoutPanel);
			this.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupBox.Location = new System.Drawing.Point(0, 0);
			this.GroupBox.Name = "GroupBox";
			this.GroupBox.Size = new System.Drawing.Size(469, 361);
			this.GroupBox.TabIndex = 1;
			this.GroupBox.TabStop = false;
			// 
			// Label
			// 
			this.Label.AutoSize = true;
			this.Label.Location = new System.Drawing.Point(3, 17);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(72, 13);
			this.Label.TabIndex = 4;
			this.Label.Text = "Installer mode";
			// 
			// ComboBox
			// 
			this.ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox.FormattingEnabled = true;
			this.ComboBox.Location = new System.Drawing.Point(105, 14);
			this.ComboBox.Name = "ComboBox";
			this.ComboBox.Size = new System.Drawing.Size(358, 21);
			this.ComboBox.TabIndex = 3;
			this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			// 
			// BtnExit
			// 
			this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnExit.Location = new System.Drawing.Point(385, 328);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(78, 27);
			this.BtnExit.TabIndex = 2;
			this.BtnExit.Text = "Exit";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// BtnFinish
			// 
			this.BtnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.BtnFinish.Location = new System.Drawing.Point(301, 328);
			this.BtnFinish.Name = "BtnFinish";
			this.BtnFinish.Size = new System.Drawing.Size(78, 27);
			this.BtnFinish.TabIndex = 0;
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
			this.LayoutPanel.TabIndex = 1;
			// 
			// BtnBack
			// 
			this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnBack.DialogResult = System.Windows.Forms.DialogResult.No;
			this.BtnBack.Location = new System.Drawing.Point(217, 328);
			this.BtnBack.Name = "BtnBack";
			this.BtnBack.Size = new System.Drawing.Size(78, 27);
			this.BtnBack.TabIndex = 10;
			this.BtnBack.Text = "Back";
			this.BtnBack.UseVisualStyleBackColor = true;
			// 
			// SelectComponentsForm
			// 
			this.AcceptButton = this.BtnFinish;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.BtnExit;
			this.ClientSize = new System.Drawing.Size(469, 361);
			this.Controls.Add(this.GroupBox);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(485, 400);
			this.MinimumSize = new System.Drawing.Size(485, 400);
			this.Name = "SelectComponentsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "{InstallerTitle} Setup";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectComponentsForm_FormClosing);
			this.Load += new System.EventHandler(this.SelectComponentsForm_Load);
			this.GroupBox.ResumeLayout(false);
			this.GroupBox.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.Button BtnFinish;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.ComboBox ComboBox;
		private System.Windows.Forms.Button BtnBack;
	}
}
