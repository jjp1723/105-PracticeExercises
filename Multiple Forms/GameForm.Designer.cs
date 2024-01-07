namespace Multiple_Forms
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.guessLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.outBox = new System.Windows.Forms.TextBox();
            this.outLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guessBox
            // 
            this.guessBox.Enabled = false;
            this.guessBox.Location = new System.Drawing.Point(137, 172);
            this.guessBox.Margin = new System.Windows.Forms.Padding(4);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(132, 22);
            this.guessBox.TabIndex = 0;
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Location = new System.Drawing.Point(25, 175);
            this.guessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(104, 17);
            this.guessLabel.TabIndex = 1;
            this.guessLabel.Text = "Current Guess:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 15);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(613, 28);
            this.progressBar.TabIndex = 2;
            // 
            // outBox
            // 
            this.outBox.Enabled = false;
            this.outBox.Location = new System.Drawing.Point(77, 261);
            this.outBox.Margin = new System.Windows.Forms.Padding(4);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(300, 22);
            this.outBox.TabIndex = 3;
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Location = new System.Drawing.Point(16, 265);
            this.outLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(52, 17);
            this.outLabel.TabIndex = 4;
            this.outLabel.Text = "Result:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // timeBox
            // 
            this.timeBox.Enabled = false;
            this.timeBox.Location = new System.Drawing.Point(77, 50);
            this.timeBox.Margin = new System.Windows.Forms.Padding(4);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(132, 22);
            this.timeBox.TabIndex = 5;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(25, 54);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(43, 17);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Time:";
            // 
            // guessButton
            // 
            this.guessButton.Enabled = false;
            this.guessButton.Location = new System.Drawing.Point(277, 169);
            this.guessButton.Margin = new System.Windows.Forms.Padding(4);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(100, 28);
            this.guessButton.TabIndex = 7;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.GuessClick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(256, 54);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(121, 46);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartClick);
            // 
            // messageBox
            // 
            this.messageBox.Enabled = false;
            this.messageBox.Location = new System.Drawing.Point(405, 139);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(228, 22);
            this.messageBox.TabIndex = 9;
            this.messageBox.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(485, 167);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(98, 30);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.CloseClick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 311);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.guessBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button closeButton;
    }
}