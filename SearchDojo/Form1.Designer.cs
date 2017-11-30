namespace SearchDojo
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.MatchedBox = new System.Windows.Forms.TextBox();
            this.PatternBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PatternLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.MatchedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 70);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(263, 235);
            this.TextBox.TabIndex = 0;
            // 
            // MatchedBox
            // 
            this.MatchedBox.Location = new System.Drawing.Point(295, 70);
            this.MatchedBox.Multiline = true;
            this.MatchedBox.Name = "MatchedBox";
            this.MatchedBox.Size = new System.Drawing.Size(248, 235);
            this.MatchedBox.TabIndex = 1;
            // 
            // PatternBox
            // 
            this.PatternBox.Location = new System.Drawing.Point(59, 324);
            this.PatternBox.Name = "PatternBox";
            this.PatternBox.Size = new System.Drawing.Size(386, 20);
            this.PatternBox.TabIndex = 2;
            this.PatternBox.TextChanged += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(451, 323);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PatternLabel
            // 
            this.PatternLabel.AutoSize = true;
            this.PatternLabel.Location = new System.Drawing.Point(12, 327);
            this.PatternLabel.Name = "PatternLabel";
            this.PatternLabel.Size = new System.Drawing.Size(41, 13);
            this.PatternLabel.TabIndex = 4;
            this.PatternLabel.Text = "Pattern";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(9, 51);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(28, 13);
            this.TextLabel.TabIndex = 5;
            this.TextLabel.Text = "Text";
            // 
            // MatchedLabel
            // 
            this.MatchedLabel.AutoSize = true;
            this.MatchedLabel.Location = new System.Drawing.Point(292, 51);
            this.MatchedLabel.Name = "MatchedLabel";
            this.MatchedLabel.Size = new System.Drawing.Size(49, 13);
            this.MatchedLabel.TabIndex = 6;
            this.MatchedLabel.Text = "Matched";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 367);
            this.Controls.Add(this.MatchedLabel);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.PatternLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PatternBox);
            this.Controls.Add(this.MatchedBox);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.TextBox MatchedBox;
        private System.Windows.Forms.TextBox PatternBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label PatternLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label MatchedLabel;
    }
}

