namespace GUI_Creation_and_Events
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wire1 = new System.Windows.Forms.Button();
            this.wire2 = new System.Windows.Forms.Button();
            this.wire3 = new System.Windows.Forms.Button();
            this.wire4 = new System.Windows.Forms.Button();
            this.wire5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.ruleBox1 = new System.Windows.Forms.TextBox();
            this.ruleBox2 = new System.Windows.Forms.TextBox();
            this.ruleBox3 = new System.Windows.Forms.TextBox();
            this.ruleBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rules:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(202, 94);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(685, 28);
            this.progressBar.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(473, 129);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(140, 36);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 432);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Progress:";
            // 
            // wire1
            // 
            this.wire1.BackColor = System.Drawing.Color.Gray;
            this.wire1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.wire1.Enabled = false;
            this.wire1.Location = new System.Drawing.Point(202, 244);
            this.wire1.Margin = new System.Windows.Forms.Padding(4);
            this.wire1.Name = "wire1";
            this.wire1.Size = new System.Drawing.Size(685, 12);
            this.wire1.TabIndex = 5;
            this.wire1.Text = "Black Wire";
            this.wire1.UseVisualStyleBackColor = false;
            this.wire1.Click += new System.EventHandler(this.WireCut);
            // 
            // wire2
            // 
            this.wire2.BackColor = System.Drawing.Color.Gray;
            this.wire2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.wire2.Enabled = false;
            this.wire2.Location = new System.Drawing.Point(202, 278);
            this.wire2.Margin = new System.Windows.Forms.Padding(4);
            this.wire2.Name = "wire2";
            this.wire2.Size = new System.Drawing.Size(685, 12);
            this.wire2.TabIndex = 6;
            this.wire2.Text = "Black Wire";
            this.wire2.UseVisualStyleBackColor = false;
            this.wire2.Click += new System.EventHandler(this.WireCut);
            // 
            // wire3
            // 
            this.wire3.BackColor = System.Drawing.Color.Gray;
            this.wire3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.wire3.Enabled = false;
            this.wire3.Location = new System.Drawing.Point(202, 317);
            this.wire3.Margin = new System.Windows.Forms.Padding(4);
            this.wire3.Name = "wire3";
            this.wire3.Size = new System.Drawing.Size(685, 12);
            this.wire3.TabIndex = 7;
            this.wire3.Text = "Black Wire";
            this.wire3.UseVisualStyleBackColor = false;
            this.wire3.Click += new System.EventHandler(this.WireCut);
            // 
            // wire4
            // 
            this.wire4.BackColor = System.Drawing.Color.Gray;
            this.wire4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.wire4.Enabled = false;
            this.wire4.Location = new System.Drawing.Point(202, 351);
            this.wire4.Margin = new System.Windows.Forms.Padding(4);
            this.wire4.Name = "wire4";
            this.wire4.Size = new System.Drawing.Size(685, 12);
            this.wire4.TabIndex = 8;
            this.wire4.Text = "Black Wire";
            this.wire4.UseVisualStyleBackColor = false;
            this.wire4.Click += new System.EventHandler(this.WireCut);
            // 
            // wire5
            // 
            this.wire5.BackColor = System.Drawing.Color.Gray;
            this.wire5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.wire5.Enabled = false;
            this.wire5.Location = new System.Drawing.Point(202, 384);
            this.wire5.Margin = new System.Windows.Forms.Padding(4);
            this.wire5.Name = "wire5";
            this.wire5.Size = new System.Drawing.Size(685, 12);
            this.wire5.TabIndex = 9;
            this.wire5.Text = "Black Wire";
            this.wire5.UseVisualStyleBackColor = false;
            this.wire5.Click += new System.EventHandler(this.WireCut);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(202, 432);
            this.resultBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(684, 93);
            this.resultBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Time:";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(202, 145);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(100, 22);
            this.timeBox.TabIndex = 12;
            // 
            // ruleBox1
            // 
            this.ruleBox1.Location = new System.Drawing.Point(71, 8);
            this.ruleBox1.Name = "ruleBox1";
            this.ruleBox1.Size = new System.Drawing.Size(461, 22);
            this.ruleBox1.TabIndex = 13;
            // 
            // ruleBox2
            // 
            this.ruleBox2.Location = new System.Drawing.Point(71, 36);
            this.ruleBox2.Name = "ruleBox2";
            this.ruleBox2.Size = new System.Drawing.Size(461, 22);
            this.ruleBox2.TabIndex = 14;
            // 
            // ruleBox3
            // 
            this.ruleBox3.Location = new System.Drawing.Point(558, 8);
            this.ruleBox3.Name = "ruleBox3";
            this.ruleBox3.Size = new System.Drawing.Size(497, 22);
            this.ruleBox3.TabIndex = 15;
            // 
            // ruleBox4
            // 
            this.ruleBox4.Location = new System.Drawing.Point(558, 36);
            this.ruleBox4.Name = "ruleBox4";
            this.ruleBox4.Size = new System.Drawing.Size(497, 22);
            this.ruleBox4.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ruleBox4);
            this.Controls.Add(this.ruleBox3);
            this.Controls.Add(this.ruleBox2);
            this.Controls.Add(this.ruleBox1);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.wire5);
            this.Controls.Add(this.wire4);
            this.Controls.Add(this.wire3);
            this.Controls.Add(this.wire2);
            this.Controls.Add(this.wire1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button wire1;
        private System.Windows.Forms.Button wire2;
        private System.Windows.Forms.Button wire3;
        private System.Windows.Forms.Button wire4;
        private System.Windows.Forms.Button wire5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox ruleBox1;
        private System.Windows.Forms.TextBox ruleBox2;
        private System.Windows.Forms.TextBox ruleBox3;
        private System.Windows.Forms.TextBox ruleBox4;
    }
}

