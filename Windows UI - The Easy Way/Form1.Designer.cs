namespace Windows_UI___The_Easy_Way
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
            this.incrementButton = new System.Windows.Forms.Button();
            this.decrementButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.textCounter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incrementButton
            // 
            this.incrementButton.Location = new System.Drawing.Point(27, 28);
            this.incrementButton.Name = "incrementButton";
            this.incrementButton.Size = new System.Drawing.Size(126, 49);
            this.incrementButton.TabIndex = 0;
            this.incrementButton.Text = "Increment";
            this.incrementButton.UseVisualStyleBackColor = true;
            // 
            // decrementButton
            // 
            this.decrementButton.Location = new System.Drawing.Point(178, 28);
            this.decrementButton.Name = "decrementButton";
            this.decrementButton.Size = new System.Drawing.Size(126, 49);
            this.decrementButton.TabIndex = 1;
            this.decrementButton.Text = "Decrement";
            this.decrementButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(329, 28);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(126, 49);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // textCounter
            // 
            this.textCounter.Location = new System.Drawing.Point(166, 110);
            this.textCounter.Name = "textCounter";
            this.textCounter.Size = new System.Drawing.Size(289, 20);
            this.textCounter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Counter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCounter);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.decrementButton);
            this.Controls.Add(this.incrementButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button incrementButton;
        private System.Windows.Forms.Button decrementButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox textCounter;
        private System.Windows.Forms.Label label1;
    }
}

