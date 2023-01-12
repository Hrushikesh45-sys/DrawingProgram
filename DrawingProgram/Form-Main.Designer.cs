namespace DrawingProgram
{
    partial class frmMainForm
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.CommandLine = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Errors = new System.Windows.Forms.Label();
            this.Multiline = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(413, 14);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(513, 425);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // CommandLine
            // 
            this.CommandLine.Location = new System.Drawing.Point(13, 449);
            this.CommandLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.Size = new System.Drawing.Size(392, 27);
            this.CommandLine.TabIndex = 0;
            // 
            // ClearButton
            // 
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Location = new System.Drawing.Point(28, 547);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(96, 40);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Errors
            // 
            this.Errors.AutoSize = true;
            this.Errors.Location = new System.Drawing.Point(412, 452);
            this.Errors.Name = "Errors";
            this.Errors.Size = new System.Drawing.Size(71, 19);
            this.Errors.TabIndex = 1;
            this.Errors.Text = "Error Log:";
            // 
            // Multiline
            // 
            this.Multiline.Location = new System.Drawing.Point(13, 14);
            this.Multiline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Multiline.Multiline = true;
            this.Multiline.Name = "Multiline";
            this.Multiline.Size = new System.Drawing.Size(392, 425);
            this.Multiline.TabIndex = 0;
            // 
            // RunButton
            // 
            this.RunButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunButton.Location = new System.Drawing.Point(28, 497);
            this.RunButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(96, 40);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(295, 497);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 40);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(295, 547);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(90, 40);
            this.LoadButton.TabIndex = 7;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 616);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CommandLine);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Multiline);
            this.Controls.Add(this.Errors);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RunButton);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainForm";
            this.Text = "DrawingProgram";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox CommandLine;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label Errors;
        private System.Windows.Forms.TextBox Multiline;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
    }
}

