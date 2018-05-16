namespace Maze
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bigTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.restartButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.gbfsLabel = new System.Windows.Forms.Label();
            this.bigTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigTableLayoutPanel
            // 
            this.bigTableLayoutPanel.BackColor = System.Drawing.Color.Snow;
            this.bigTableLayoutPanel.ColumnCount = 5;
            this.bigTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bigTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.bigTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.bigTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.bigTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.bigTableLayoutPanel.Controls.Add(this.startButton, 0, 1);
            this.bigTableLayoutPanel.Controls.Add(this.messageLabel, 2, 1);
            this.bigTableLayoutPanel.Controls.Add(this.progressBar, 3, 1);
            this.bigTableLayoutPanel.Controls.Add(this.restartButton, 0, 3);
            this.bigTableLayoutPanel.Controls.Add(this.timeLabel, 2, 3);
            this.bigTableLayoutPanel.Controls.Add(this.closeButton, 4, 3);
            this.bigTableLayoutPanel.Controls.Add(this.gbfsLabel, 3, 3);
            this.bigTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bigTableLayoutPanel.Location = new System.Drawing.Point(35, 35);
            this.bigTableLayoutPanel.Name = "bigTableLayoutPanel";
            this.bigTableLayoutPanel.RowCount = 4;
            this.bigTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.bigTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.72962F));
            this.bigTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.590457F));
            this.bigTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51889F));
            this.bigTableLayoutPanel.Size = new System.Drawing.Size(937, 503);
            this.bigTableLayoutPanel.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Gold;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(3, 372);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(181, 52);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.messageLabel.Location = new System.Drawing.Point(208, 369);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(275, 58);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Message to be printed....";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.bigTableLayoutPanel.SetColumnSpan(this.progressBar, 2);
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(489, 372);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(445, 52);
            this.progressBar.TabIndex = 3;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Gold;
            this.restartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.restartButton.Location = new System.Drawing.Point(3, 437);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(181, 63);
            this.restartButton.TabIndex = 4;
            this.restartButton.Text = "Restart Maze";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Location = new System.Drawing.Point(208, 434);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(275, 69);
            this.timeLabel.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Gold;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.Location = new System.Drawing.Point(770, 437);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(164, 63);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close Maze";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // gbfsLabel
            // 
            this.gbfsLabel.AutoSize = true;
            this.gbfsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbfsLabel.Location = new System.Drawing.Point(489, 434);
            this.gbfsLabel.Name = "gbfsLabel";
            this.gbfsLabel.Size = new System.Drawing.Size(275, 69);
            this.gbfsLabel.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maze.ResourcePictures.pattern;
            this.ClientSize = new System.Drawing.Size(1007, 573);
            this.Controls.Add(this.bigTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(35);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze";
            this.bigTableLayoutPanel.ResumeLayout(false);
            this.bigTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel bigTableLayoutPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label gbfsLabel;
    }
}