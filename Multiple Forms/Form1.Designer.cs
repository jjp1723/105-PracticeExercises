namespace Multiple_Forms
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
            this.lowBox = new System.Windows.Forms.TextBox();
            this.highBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.lowLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.readyButton = new System.Windows.Forms.Button();
            this.lowErrorBox = new System.Windows.Forms.TextBox();
            this.highErrorBox = new System.Windows.Forms.TextBox();
            this.timeErrorBox = new System.Windows.Forms.TextBox();
            this.lowButton = new System.Windows.Forms.Button();
            this.highButton = new System.Windows.Forms.Button();
            this.timeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lowBox
            // 
            this.lowBox.Location = new System.Drawing.Point(209, 112);
            this.lowBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lowBox.Name = "lowBox";
            this.lowBox.Size = new System.Drawing.Size(132, 22);
            this.lowBox.TabIndex = 0;
            // 
            // highBox
            // 
            this.highBox.Location = new System.Drawing.Point(209, 144);
            this.highBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.highBox.Name = "highBox";
            this.highBox.Size = new System.Drawing.Size(132, 22);
            this.highBox.TabIndex = 1;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(209, 196);
            this.timeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(132, 22);
            this.timeBox.TabIndex = 2;
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.Location = new System.Drawing.Point(132, 116);
            this.lowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(66, 17);
            this.lowLabel.TabIndex = 3;
            this.lowLabel.Text = "Low End:";
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Location = new System.Drawing.Point(132, 148);
            this.highLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(70, 17);
            this.highLabel.TabIndex = 4;
            this.highLabel.Text = "High End:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(157, 199);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(43, 17);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Time:";
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Location = new System.Drawing.Point(16, 11);
            this.greetingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(325, 17);
            this.greetingLabel.TabIndex = 6;
            this.greetingLabel.Text = "Hello, and welcome to the number guessing game!";
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Location = new System.Drawing.Point(16, 50);
            this.directionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(606, 17);
            this.directionLabel.TabIndex = 7;
            this.directionLabel.Text = "Please enter the desired range for the randomly generated number as well as the d" +
    "esired time.";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(16, 252);
            this.startLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(434, 17);
            this.startLabel.TabIndex = 8;
            this.startLabel.Text = "Once you have entered the appropriate information, press \"Ready\".";
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(243, 297);
            this.readyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(100, 28);
            this.readyButton.TabIndex = 9;
            this.readyButton.Text = "Ready";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.ReadyClick);
            // 
            // lowErrorBox
            // 
            this.lowErrorBox.Enabled = false;
            this.lowErrorBox.Location = new System.Drawing.Point(471, 112);
            this.lowErrorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lowErrorBox.Name = "lowErrorBox";
            this.lowErrorBox.Size = new System.Drawing.Size(132, 22);
            this.lowErrorBox.TabIndex = 10;
            // 
            // highErrorBox
            // 
            this.highErrorBox.Enabled = false;
            this.highErrorBox.Location = new System.Drawing.Point(471, 144);
            this.highErrorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.highErrorBox.Name = "highErrorBox";
            this.highErrorBox.Size = new System.Drawing.Size(132, 22);
            this.highErrorBox.TabIndex = 11;
            // 
            // timeErrorBox
            // 
            this.timeErrorBox.Enabled = false;
            this.timeErrorBox.Location = new System.Drawing.Point(471, 196);
            this.timeErrorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeErrorBox.Name = "timeErrorBox";
            this.timeErrorBox.Size = new System.Drawing.Size(132, 22);
            this.timeErrorBox.TabIndex = 12;
            // 
            // lowButton
            // 
            this.lowButton.Location = new System.Drawing.Point(348, 112);
            this.lowButton.Name = "lowButton";
            this.lowButton.Size = new System.Drawing.Size(75, 23);
            this.lowButton.TabIndex = 13;
            this.lowButton.Text = "Enter";
            this.lowButton.UseVisualStyleBackColor = true;
            this.lowButton.Click += new System.EventHandler(this.EnterLowClick);
            // 
            // highButton
            // 
            this.highButton.Location = new System.Drawing.Point(348, 145);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(75, 23);
            this.highButton.TabIndex = 14;
            this.highButton.Text = "Enter";
            this.highButton.UseVisualStyleBackColor = true;
            this.highButton.Click += new System.EventHandler(this.EnterHighClick);
            // 
            // timeButton
            // 
            this.timeButton.Location = new System.Drawing.Point(348, 196);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(75, 23);
            this.timeButton.TabIndex = 15;
            this.timeButton.Text = "Enter";
            this.timeButton.UseVisualStyleBackColor = true;
            this.timeButton.Click += new System.EventHandler(this.EnterTimeClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 340);
            this.Controls.Add(this.timeButton);
            this.Controls.Add(this.highButton);
            this.Controls.Add(this.lowButton);
            this.Controls.Add(this.timeErrorBox);
            this.Controls.Add(this.highErrorBox);
            this.Controls.Add(this.lowErrorBox);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.highBox);
            this.Controls.Add(this.lowBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lowBox;
        private System.Windows.Forms.TextBox highBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.TextBox lowErrorBox;
        private System.Windows.Forms.TextBox highErrorBox;
        private System.Windows.Forms.TextBox timeErrorBox;
        private System.Windows.Forms.Button lowButton;
        private System.Windows.Forms.Button highButton;
        private System.Windows.Forms.Button timeButton;
    }
}

