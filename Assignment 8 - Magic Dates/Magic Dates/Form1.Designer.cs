namespace Magic_Dates
{
    partial class magicDates
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
            this.exitButton = new System.Windows.Forms.Button();
            this.dayLabel = new System.Windows.Forms.Label();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.dateFormatLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(99, 245);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(13, 16);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(118, 13);
            this.dayLabel.TabIndex = 1;
            this.dayLabel.Text = "Enter a day (numerical):";
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(160, 12);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayTextBox.TabIndex = 1;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(160, 38);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 2;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(13, 42);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(130, 13);
            this.monthLabel.TabIndex = 5;
            this.monthLabel.Text = "Enter a month (numerical):";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(160, 64);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 3;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(13, 68);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(141, 13);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Enter a year (numerical, YY):";
            this.yearLabel.Click += new System.EventHandler(this.yearLabel_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 176);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(248, 55);
            this.outputLabel.TabIndex = 10;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateFormatLabel
            // 
            this.dateFormatLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFormatLabel.Location = new System.Drawing.Point(12, 133);
            this.dateFormatLabel.Name = "dateFormatLabel";
            this.dateFormatLabel.Size = new System.Drawing.Size(248, 28);
            this.dateFormatLabel.TabIndex = 12;
            this.dateFormatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "You entered:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(173, 90);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Submit Date";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // magicDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 279);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dateFormatLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.exitButton);
            this.Name = "magicDates";
            this.Text = "Magic Dates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label dateFormatLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitButton;
    }
}

