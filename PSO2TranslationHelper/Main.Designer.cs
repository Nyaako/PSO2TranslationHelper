namespace PSO2TranslationHelper
{
    partial class Main
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
            this.translationGridView = new System.Windows.Forms.DataGridView();
            this.translationSearchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.mainFormProgressBar = new System.Windows.Forms.ProgressBar();
            this.mainFormProgressLabel = new System.Windows.Forms.Label();
            this.optionOpenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.translationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // translationGridView
            // 
            this.translationGridView.AllowUserToAddRows = false;
            this.translationGridView.AllowUserToDeleteRows = false;
            this.translationGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.translationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.translationGridView.Location = new System.Drawing.Point(12, 49);
            this.translationGridView.Name = "translationGridView";
            this.translationGridView.ReadOnly = true;
            this.translationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.translationGridView.Size = new System.Drawing.Size(777, 388);
            this.translationGridView.TabIndex = 0;
            this.translationGridView.VirtualMode = true;
            this.translationGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TranslationGridView_CellDoubleClick);
            this.translationGridView.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.TranslationGridView_CellValueNeeded);
            // 
            // translationSearchBox
            // 
            this.translationSearchBox.Location = new System.Drawing.Point(12, 23);
            this.translationSearchBox.Name = "translationSearchBox";
            this.translationSearchBox.Size = new System.Drawing.Size(362, 20);
            this.translationSearchBox.TabIndex = 1;
            this.translationSearchBox.TextChanged += new System.EventHandler(this.TranslationSearchBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 4);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search";
            // 
            // mainFormProgressBar
            // 
            this.mainFormProgressBar.Location = new System.Drawing.Point(635, 443);
            this.mainFormProgressBar.Name = "mainFormProgressBar";
            this.mainFormProgressBar.Size = new System.Drawing.Size(154, 19);
            this.mainFormProgressBar.TabIndex = 3;
            this.mainFormProgressBar.Visible = false;
            // 
            // mainFormProgressLabel
            // 
            this.mainFormProgressLabel.AutoSize = true;
            this.mainFormProgressLabel.Location = new System.Drawing.Point(511, 446);
            this.mainFormProgressLabel.Name = "mainFormProgressLabel";
            this.mainFormProgressLabel.Size = new System.Drawing.Size(0, 13);
            this.mainFormProgressLabel.TabIndex = 4;
            // 
            // optionOpenButton
            // 
            this.optionOpenButton.Location = new System.Drawing.Point(714, 20);
            this.optionOpenButton.Name = "optionOpenButton";
            this.optionOpenButton.Size = new System.Drawing.Size(75, 23);
            this.optionOpenButton.TabIndex = 5;
            this.optionOpenButton.Text = "Options";
            this.optionOpenButton.UseVisualStyleBackColor = true;
            this.optionOpenButton.Click += new System.EventHandler(this.OptionOpenButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 464);
            this.Controls.Add(this.optionOpenButton);
            this.Controls.Add(this.mainFormProgressLabel);
            this.Controls.Add(this.mainFormProgressBar);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.translationSearchBox);
            this.Controls.Add(this.translationGridView);
            this.Name = "Main";
            this.Text = "PSO2 Translation Helper";
            ((System.ComponentModel.ISupportInitialize)(this.translationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        public System.Windows.Forms.DataGridView translationGridView;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ProgressBar mainFormProgressBar;
        private System.Windows.Forms.Label mainFormProgressLabel;
        private System.Windows.Forms.TextBox translationSearchBox;
        private System.Windows.Forms.Button optionOpenButton;
    }
}