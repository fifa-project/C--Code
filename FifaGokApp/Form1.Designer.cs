namespace FifaGokApp
{
    partial class Form1
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
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.bedButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.ItemHeight = 16;
            this.teamsListBox.Location = new System.Drawing.Point(12, 12);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(196, 260);
            this.teamsListBox.TabIndex = 0;
            // 
            // bedButton
            // 
            this.bedButton.Location = new System.Drawing.Point(343, 32);
            this.bedButton.Name = "bedButton";
            this.bedButton.Size = new System.Drawing.Size(75, 23);
            this.bedButton.TabIndex = 1;
            this.bedButton.Text = "Wedden";
            this.bedButton.UseVisualStyleBackColor = true;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(214, 57);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(184, 17);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Laat zien op wie en hoeveel";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(214, 12);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(83, 17);
            this.teamNameLabel.TabIndex = 3;
            this.teamNameLabel.Text = "Team naam";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(217, 32);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.amountNumericUpDown.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 283);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.bedButton);
            this.Controls.Add(this.teamsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.Button bedButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}

