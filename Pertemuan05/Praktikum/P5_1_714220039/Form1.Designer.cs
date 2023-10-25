namespace P5_1_714220039
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
            this.OutputLabel = new System.Windows.Forms.Label();
            this.HelloButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(175, 44);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(2, 25);
            this.OutputLabel.TabIndex = 0;
            // 
            // HelloButton
            // 
            this.HelloButton.Location = new System.Drawing.Point(85, 93);
            this.HelloButton.Name = "HelloButton";
            this.HelloButton.Size = new System.Drawing.Size(104, 23);
            this.HelloButton.TabIndex = 1;
            this.HelloButton.Text = "Say Hello";
            this.HelloButton.UseVisualStyleBackColor = true;
            this.HelloButton.Click += new System.EventHandler(this.HelloButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(218, 93);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(99, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(381, 202);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HelloButton);
            this.Controls.Add(this.OutputLabel);
            this.Name = "Form1";
            this.Text = "Form Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button HelloButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

