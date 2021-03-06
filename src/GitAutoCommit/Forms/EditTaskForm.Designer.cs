﻿namespace GitAutoCommit.Forms
{
    partial class EditTaskForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.commitMessageTextBox = new System.Windows.Forms.TextBox();
            this.commitMessageLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.browseFolderButton = new System.Windows.Forms.Button();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.folderLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.intervalComboBox);
            this.panel1.Controls.Add(this.intervalLabel);
            this.panel1.Controls.Add(this.browseFolderButton);
            this.panel1.Controls.Add(this.folderTextBox);
            this.panel1.Controls.Add(this.folderLabel);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Controls.Add(this.commitMessageLabel);
            this.panel1.Controls.Add(this.commitMessageTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Size = new System.Drawing.Size(397, 264);
            this.panel1.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(4, 40);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(101, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(293, 21);
            this.nameTextBox.TabIndex = 4;
            // 
            // commitMessageTextBox
            // 
            this.commitMessageTextBox.AcceptsReturn = true;
            this.commitMessageTextBox.AcceptsTab = true;
            this.commitMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commitMessageTextBox.Location = new System.Drawing.Point(101, 91);
            this.commitMessageTextBox.Multiline = true;
            this.commitMessageTextBox.Name = "commitMessageTextBox";
            this.commitMessageTextBox.Size = new System.Drawing.Size(293, 139);
            this.commitMessageTextBox.TabIndex = 6;
            // 
            // commitMessageLabel
            // 
            this.commitMessageLabel.AutoSize = true;
            this.commitMessageLabel.Location = new System.Drawing.Point(4, 94);
            this.commitMessageLabel.Name = "commitMessageLabel";
            this.commitMessageLabel.Size = new System.Drawing.Size(91, 13);
            this.commitMessageLabel.TabIndex = 5;
            this.commitMessageLabel.Text = "Commit message:";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(319, 236);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(238, 236);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 25);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // browseFolderButton
            // 
            this.browseFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseFolderButton.Location = new System.Drawing.Point(364, 10);
            this.browseFolderButton.Name = "browseFolderButton";
            this.browseFolderButton.Size = new System.Drawing.Size(30, 21);
            this.browseFolderButton.TabIndex = 2;
            this.browseFolderButton.Text = "...";
            this.browseFolderButton.UseVisualStyleBackColor = true;
            this.browseFolderButton.Click += new System.EventHandler(this.browseFolderButton_Click);
            // 
            // folderTextBox
            // 
            this.folderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTextBox.Location = new System.Drawing.Point(101, 10);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(257, 21);
            this.folderTextBox.TabIndex = 1;
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(4, 14);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(41, 13);
            this.folderLabel.TabIndex = 0;
            this.folderLabel.Text = "Folder:";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(4, 67);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(49, 13);
            this.intervalLabel.TabIndex = 9;
            this.intervalLabel.Text = "Interval:";
            // 
            // intervalComboBox
            // 
            this.intervalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalComboBox.FormattingEnabled = true;
            this.intervalComboBox.Location = new System.Drawing.Point(101, 64);
            this.intervalComboBox.Name = "intervalComboBox";
            this.intervalComboBox.Size = new System.Drawing.Size(293, 21);
            this.intervalComboBox.TabIndex = 10;
            // 
            // EditTaskForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(417, 333);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTaskForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "edit task";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label commitMessageLabel;
        private System.Windows.Forms.TextBox commitMessageTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button browseFolderButton;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.ComboBox intervalComboBox;
        private System.Windows.Forms.Label intervalLabel;

    }
}