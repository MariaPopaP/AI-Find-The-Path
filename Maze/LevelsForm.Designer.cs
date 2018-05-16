namespace Maze
{
    partial class LevelsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.level1RadioButton = new System.Windows.Forms.RadioButton();
            this.level2RadioButton = new System.Windows.Forms.RadioButton();
            this.level3RadioButton = new System.Windows.Forms.RadioButton();
            this.levelButton = new System.Windows.Forms.Button();
            this.levelAttentionLabel1 = new System.Windows.Forms.Label();
            this.levelAttentionLabel2 = new System.Windows.Forms.Label();
            this.levelAttentionLabel3 = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Snow;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.level1RadioButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.level2RadioButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.level3RadioButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.levelButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.levelAttentionLabel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.levelAttentionLabel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.levelAttentionLabel3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.levelLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // level1RadioButton
            // 
            this.level1RadioButton.AutoSize = true;
            this.level1RadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.level1RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.level1RadioButton.Location = new System.Drawing.Point(214, 3);
            this.level1RadioButton.Name = "level1RadioButton";
            this.level1RadioButton.Size = new System.Drawing.Size(162, 44);
            this.level1RadioButton.TabIndex = 1;
            this.level1RadioButton.TabStop = true;
            this.level1RadioButton.Text = "easy";
            this.level1RadioButton.UseVisualStyleBackColor = true;
            // 
            // level2RadioButton
            // 
            this.level2RadioButton.AutoSize = true;
            this.level2RadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.level2RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.level2RadioButton.Location = new System.Drawing.Point(214, 53);
            this.level2RadioButton.Name = "level2RadioButton";
            this.level2RadioButton.Size = new System.Drawing.Size(162, 44);
            this.level2RadioButton.TabIndex = 2;
            this.level2RadioButton.TabStop = true;
            this.level2RadioButton.Text = "medium";
            this.level2RadioButton.UseVisualStyleBackColor = true;
            // 
            // level3RadioButton
            // 
            this.level3RadioButton.AutoSize = true;
            this.level3RadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.level3RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.level3RadioButton.Location = new System.Drawing.Point(214, 103);
            this.level3RadioButton.Name = "level3RadioButton";
            this.level3RadioButton.Size = new System.Drawing.Size(162, 44);
            this.level3RadioButton.TabIndex = 3;
            this.level3RadioButton.TabStop = true;
            this.level3RadioButton.Text = "hard";
            this.level3RadioButton.UseVisualStyleBackColor = true;
            // 
            // levelButton
            // 
            this.levelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.levelButton.BackgroundImage = global::Maze.ResourcePictures.next;
            this.levelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.SetColumnSpan(this.levelButton, 2);
            this.levelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelButton.Location = new System.Drawing.Point(214, 215);
            this.levelButton.Name = "levelButton";
            this.levelButton.Size = new System.Drawing.Size(205, 65);
            this.levelButton.TabIndex = 4;
            this.levelButton.UseVisualStyleBackColor = false;
            this.levelButton.Click += new System.EventHandler(this.levelButton_Click);
            // 
            // levelAttentionLabel1
            // 
            this.levelAttentionLabel1.AutoSize = true;
            this.levelAttentionLabel1.BackColor = System.Drawing.Color.Red;
            this.levelAttentionLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelAttentionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelAttentionLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.levelAttentionLabel1.Location = new System.Drawing.Point(382, 0);
            this.levelAttentionLabel1.Name = "levelAttentionLabel1";
            this.levelAttentionLabel1.Size = new System.Drawing.Size(37, 50);
            this.levelAttentionLabel1.TabIndex = 5;
            this.levelAttentionLabel1.Text = "!!!";
            this.levelAttentionLabel1.Visible = false;
            // 
            // levelAttentionLabel2
            // 
            this.levelAttentionLabel2.AutoSize = true;
            this.levelAttentionLabel2.BackColor = System.Drawing.Color.Red;
            this.levelAttentionLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelAttentionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelAttentionLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.levelAttentionLabel2.Location = new System.Drawing.Point(382, 50);
            this.levelAttentionLabel2.Name = "levelAttentionLabel2";
            this.levelAttentionLabel2.Size = new System.Drawing.Size(37, 50);
            this.levelAttentionLabel2.TabIndex = 6;
            this.levelAttentionLabel2.Text = "!!!";
            this.levelAttentionLabel2.Visible = false;
            // 
            // levelAttentionLabel3
            // 
            this.levelAttentionLabel3.AutoSize = true;
            this.levelAttentionLabel3.BackColor = System.Drawing.Color.Red;
            this.levelAttentionLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelAttentionLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelAttentionLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.levelAttentionLabel3.Location = new System.Drawing.Point(382, 100);
            this.levelAttentionLabel3.Name = "levelAttentionLabel3";
            this.levelAttentionLabel3.Size = new System.Drawing.Size(37, 50);
            this.levelAttentionLabel3.TabIndex = 7;
            this.levelAttentionLabel3.Text = "!!!";
            this.levelAttentionLabel3.Visible = false;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelLabel.Location = new System.Drawing.Point(3, 0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(205, 50);
            this.levelLabel.TabIndex = 8;
            this.levelLabel.Text = "Choose a difficulty level:";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 333);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.Name = "LevelsForm";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton level1RadioButton;
        private System.Windows.Forms.RadioButton level2RadioButton;
        private System.Windows.Forms.RadioButton level3RadioButton;
        private System.Windows.Forms.Button levelButton;
        private System.Windows.Forms.Label levelAttentionLabel1;
        private System.Windows.Forms.Label levelAttentionLabel2;
        private System.Windows.Forms.Label levelAttentionLabel3;
        private System.Windows.Forms.Label levelLabel;
    }
}