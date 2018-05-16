namespace Maze
{
    partial class TypeMazeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeMazeForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textLabel = new System.Windows.Forms.Label();
            this.defaultButton = new System.Windows.Forms.Button();
            this.customButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Snow;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.Controls.Add(this.textLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.defaultButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.customButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.backButton, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.textLabel, 3);
            this.textLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textLabel.Location = new System.Drawing.Point(3, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(416, 65);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Do you want to personalize  the maze?";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defaultButton
            // 
            this.defaultButton.BackColor = System.Drawing.Color.Gold;
            this.defaultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.defaultButton.Location = new System.Drawing.Point(3, 76);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(196, 61);
            this.defaultButton.TabIndex = 0;
            this.defaultButton.Text = "Default";
            this.defaultButton.UseVisualStyleBackColor = false;
            this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
            // 
            // customButton
            // 
            this.customButton.BackColor = System.Drawing.Color.Gold;
            this.customButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customButton.Location = new System.Drawing.Point(221, 76);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(198, 61);
            this.customButton.TabIndex = 2;
            this.customButton.Text = "Custom";
            this.customButton.UseVisualStyleBackColor = false;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backButton.BackgroundImage = global::Maze.ResourcePictures.back;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.Location = new System.Drawing.Point(221, 216);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(198, 64);
            this.backButton.TabIndex = 3;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // TypeMazeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maze.ResourcePictures.pattern;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 333);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TypeMazeForm";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypeMazeForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.Button customButton;
        private System.Windows.Forms.Button backButton;
    }
}