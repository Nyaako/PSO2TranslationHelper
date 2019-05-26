
namespace PSO2TranslationHelper
{
    partial class OptionsForm
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
            this.optionsGithubFolderSelectorTextbox = new System.Windows.Forms.TextBox();
            this.optionsGithubFolderSelectorButton = new System.Windows.Forms.Button();
            this.optionsGithubFolderLabel = new System.Windows.Forms.Label();
            this.optionsRequiredGroupBox = new System.Windows.Forms.GroupBox();
            this.optionsEditorPathLabel = new System.Windows.Forms.Label();
            this.optionsEditorPathTextbox = new System.Windows.Forms.TextBox();
            this.optionsSelectEditorButton = new System.Windows.Forms.Button();
            this.optionsConfirmButton = new System.Windows.Forms.Button();
            this.optionsOptionalGroupBox = new System.Windows.Forms.GroupBox();
            this.optionsOptionalEditorArgsLabel = new System.Windows.Forms.Label();
            this.optionsOptionalEditorArgsLabel2 = new System.Windows.Forms.Label();
            this.optionsEditorArgsTextbox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.optionsRequiredGroupBox.SuspendLayout();
            this.optionsOptionalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsGithubFolderSelectorTextbox
            // 
            this.optionsGithubFolderSelectorTextbox.Location = new System.Drawing.Point(12, 45);
            this.optionsGithubFolderSelectorTextbox.Name = "optionsGithubFolderSelectorTextbox";
            this.optionsGithubFolderSelectorTextbox.ReadOnly = true;
            this.optionsGithubFolderSelectorTextbox.Size = new System.Drawing.Size(128, 20);
            this.optionsGithubFolderSelectorTextbox.TabIndex = 0;
            // 
            // optionsGithubFolderSelectorButton
            // 
            this.optionsGithubFolderSelectorButton.Location = new System.Drawing.Point(146, 45);
            this.optionsGithubFolderSelectorButton.Name = "optionsGithubFolderSelectorButton";
            this.optionsGithubFolderSelectorButton.Size = new System.Drawing.Size(90, 20);
            this.optionsGithubFolderSelectorButton.TabIndex = 1;
            this.optionsGithubFolderSelectorButton.Text = "Select Folder";
            this.optionsGithubFolderSelectorButton.UseVisualStyleBackColor = true;
            this.optionsGithubFolderSelectorButton.Click += new System.EventHandler(this.OptionsGithubFolderSelectorButton_Click);
            // 
            // optionsGithubFolderLabel
            // 
            this.optionsGithubFolderLabel.AutoSize = true;
            this.optionsGithubFolderLabel.Location = new System.Drawing.Point(9, 29);
            this.optionsGithubFolderLabel.Name = "optionsGithubFolderLabel";
            this.optionsGithubFolderLabel.Size = new System.Drawing.Size(150, 13);
            this.optionsGithubFolderLabel.TabIndex = 2;
            this.optionsGithubFolderLabel.Text = "Translation Github Folder Path";
            // 
            // optionsRequiredGroupBox
            // 
            this.optionsRequiredGroupBox.AutoSize = true;
            this.optionsRequiredGroupBox.Controls.Add(this.optionsEditorPathLabel);
            this.optionsRequiredGroupBox.Controls.Add(this.optionsGithubFolderLabel);
            this.optionsRequiredGroupBox.Controls.Add(this.optionsEditorPathTextbox);
            this.optionsRequiredGroupBox.Controls.Add(this.optionsGithubFolderSelectorTextbox);
            this.optionsRequiredGroupBox.Controls.Add(this.optionsSelectEditorButton);
            this.optionsRequiredGroupBox.Controls.Add(this.optionsGithubFolderSelectorButton);
            this.optionsRequiredGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionsRequiredGroupBox.Location = new System.Drawing.Point(0, 0);
            this.optionsRequiredGroupBox.Name = "optionsRequiredGroupBox";
            this.optionsRequiredGroupBox.Size = new System.Drawing.Size(349, 135);
            this.optionsRequiredGroupBox.TabIndex = 3;
            this.optionsRequiredGroupBox.TabStop = false;
            this.optionsRequiredGroupBox.Text = "Required";
            // 
            // optionsEditorPathLabel
            // 
            this.optionsEditorPathLabel.AutoSize = true;
            this.optionsEditorPathLabel.Location = new System.Drawing.Point(9, 80);
            this.optionsEditorPathLabel.Name = "optionsEditorPathLabel";
            this.optionsEditorPathLabel.Size = new System.Drawing.Size(59, 13);
            this.optionsEditorPathLabel.TabIndex = 5;
            this.optionsEditorPathLabel.Text = "Editor Path";
            // 
            // optionsEditorPathTextbox
            // 
            this.optionsEditorPathTextbox.Location = new System.Drawing.Point(12, 96);
            this.optionsEditorPathTextbox.Name = "optionsEditorPathTextbox";
            this.optionsEditorPathTextbox.ReadOnly = true;
            this.optionsEditorPathTextbox.Size = new System.Drawing.Size(128, 20);
            this.optionsEditorPathTextbox.TabIndex = 3;
            // 
            // optionsSelectEditorButton
            // 
            this.optionsSelectEditorButton.Location = new System.Drawing.Point(146, 96);
            this.optionsSelectEditorButton.Name = "optionsSelectEditorButton";
            this.optionsSelectEditorButton.Size = new System.Drawing.Size(90, 20);
            this.optionsSelectEditorButton.TabIndex = 4;
            this.optionsSelectEditorButton.Text = "Select Editor";
            this.optionsSelectEditorButton.UseVisualStyleBackColor = true;
            this.optionsSelectEditorButton.Click += new System.EventHandler(this.OptionsSelectEditorButton_Click);
            // 
            // optionsConfirmButton
            // 
            this.optionsConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsConfirmButton.Location = new System.Drawing.Point(258, 295);
            this.optionsConfirmButton.Name = "optionsConfirmButton";
            this.optionsConfirmButton.Size = new System.Drawing.Size(79, 25);
            this.optionsConfirmButton.TabIndex = 4;
            this.optionsConfirmButton.Text = "Confirm";
            this.optionsConfirmButton.UseVisualStyleBackColor = true;
            this.optionsConfirmButton.Click += new System.EventHandler(this.OptionsConfirmButton_Click);
            // 
            // optionsOptionalGroupBox
            // 
            this.optionsOptionalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsOptionalGroupBox.AutoSize = true;
            this.optionsOptionalGroupBox.Controls.Add(this.optionsOptionalEditorArgsLabel);
            this.optionsOptionalGroupBox.Controls.Add(this.optionsOptionalEditorArgsLabel2);
            this.optionsOptionalGroupBox.Controls.Add(this.optionsEditorArgsTextbox);
            this.optionsOptionalGroupBox.Location = new System.Drawing.Point(0, 132);
            this.optionsOptionalGroupBox.Name = "optionsOptionalGroupBox";
            this.optionsOptionalGroupBox.Size = new System.Drawing.Size(349, 157);
            this.optionsOptionalGroupBox.TabIndex = 5;
            this.optionsOptionalGroupBox.TabStop = false;
            this.optionsOptionalGroupBox.Text = "Optional";
            // 
            // optionsOptionalEditorArgsLabel
            // 
            this.optionsOptionalEditorArgsLabel.AutoSize = true;
            this.optionsOptionalEditorArgsLabel.Location = new System.Drawing.Point(9, 28);
            this.optionsOptionalEditorArgsLabel.Name = "optionsOptionalEditorArgsLabel";
            this.optionsOptionalEditorArgsLabel.Size = new System.Drawing.Size(87, 13);
            this.optionsOptionalEditorArgsLabel.TabIndex = 2;
            this.optionsOptionalEditorArgsLabel.Text = "Editor Arguments";
            // 
            // optionsOptionalEditorArgsLabel2
            // 
            this.optionsOptionalEditorArgsLabel2.AutoSize = true;
            this.optionsOptionalEditorArgsLabel2.Location = new System.Drawing.Point(146, 47);
            this.optionsOptionalEditorArgsLabel2.Name = "optionsOptionalEditorArgsLabel2";
            this.optionsOptionalEditorArgsLabel2.Size = new System.Drawing.Size(63, 13);
            this.optionsOptionalEditorArgsLabel2.TabIndex = 1;
            this.optionsOptionalEditorArgsLabel2.Text = "{f} filename ";
            // 
            // optionsEditorArgsTextbox
            // 
            this.optionsEditorArgsTextbox.Location = new System.Drawing.Point(12, 44);
            this.optionsEditorArgsTextbox.Name = "optionsEditorArgsTextbox";
            this.optionsEditorArgsTextbox.Size = new System.Drawing.Size(128, 20);
            this.optionsEditorArgsTextbox.TabIndex = 0;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 332);
            this.Controls.Add(this.optionsOptionalGroupBox);
            this.Controls.Add(this.optionsConfirmButton);
            this.Controls.Add(this.optionsRequiredGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            this.optionsRequiredGroupBox.ResumeLayout(false);
            this.optionsRequiredGroupBox.PerformLayout();
            this.optionsOptionalGroupBox.ResumeLayout(false);
            this.optionsOptionalGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox optionsGithubFolderSelectorTextbox;
        private System.Windows.Forms.Button optionsGithubFolderSelectorButton;
        private System.Windows.Forms.Label optionsGithubFolderLabel;
        private System.Windows.Forms.GroupBox optionsRequiredGroupBox;
        private System.Windows.Forms.Button optionsConfirmButton;
        private System.Windows.Forms.Label optionsEditorPathLabel;
        private System.Windows.Forms.TextBox optionsEditorPathTextbox;
        private System.Windows.Forms.Button optionsSelectEditorButton;
        private System.Windows.Forms.GroupBox optionsOptionalGroupBox;
        private System.Windows.Forms.Label optionsOptionalEditorArgsLabel;
        private System.Windows.Forms.Label optionsOptionalEditorArgsLabel2;
        private System.Windows.Forms.TextBox optionsEditorArgsTextbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}