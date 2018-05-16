namespace Maze
{
    partial class DimensionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DimensionsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rowsNumberTextBox = new System.Windows.Forms.TextBox();
            this.columnsNumberTextBox = new System.Windows.Forms.TextBox();
            this.attentionRowLabel = new System.Windows.Forms.Label();
            this.attentionColumnLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.rowsNumberTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.columnsNumberTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.attentionRowLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.attentionColumnLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.okButton, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rowsNumberTextBox
            // 
            this.rowsNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowsNumberTextBox.Location = new System.Drawing.Point(214, 3);
            this.rowsNumberTextBox.Name = "rowsNumberTextBox";
            this.rowsNumberTextBox.Size = new System.Drawing.Size(162, 22);
            this.rowsNumberTextBox.TabIndex = 1;
            // 
            // columnsNumberTextBox
            // 
            this.columnsNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columnsNumberTextBox.Location = new System.Drawing.Point(214, 59);
            this.columnsNumberTextBox.Name = "columnsNumberTextBox";
            this.columnsNumberTextBox.Size = new System.Drawing.Size(162, 22);
            this.columnsNumberTextBox.TabIndex = 2;
            // 
            // attentionRowLabel
            // 
            this.attentionRowLabel.AutoSize = true;
            this.attentionRowLabel.BackColor = System.Drawing.Color.Red;
            this.attentionRowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attentionRowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attentionRowLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.attentionRowLabel.Location = new System.Drawing.Point(382, 0);
            this.attentionRowLabel.Name = "attentionRowLabel";
            this.attentionRowLabel.Size = new System.Drawing.Size(37, 56);
            this.attentionRowLabel.TabIndex = 5;
            this.attentionRowLabel.Text = "!!!";
            this.attentionRowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.attentionRowLabel.Visible = false;
            // 
            // attentionColumnLabel
            // 
            this.attentionColumnLabel.AutoSize = true;
            this.attentionColumnLabel.BackColor = System.Drawing.Color.Red;
            this.attentionColumnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attentionColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attentionColumnLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.attentionColumnLabel.Location = new System.Drawing.Point(382, 56);
            this.attentionColumnLabel.Name = "attentionColumnLabel";
            this.attentionColumnLabel.Size = new System.Drawing.Size(37, 56);
            this.attentionColumnLabel.TabIndex = 6;
            this.attentionColumnLabel.Text = "!!!";
            this.attentionColumnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.attentionColumnLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of Rows:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 56);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of Columns:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.okButton.BackgroundImage = global::Maze.ResourcePictures.next;
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.SetColumnSpan(this.okButton, 2);
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(214, 214);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(205, 66);
            this.okButton.TabIndex = 0;
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // DimensionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maze.ResourcePictures.pattern;
            this.ClientSize = new System.Drawing.Size(472, 333);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DimensionsForm";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DimensionsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox rowsNumberTextBox;
        private System.Windows.Forms.TextBox columnsNumberTextBox;
        private System.Windows.Forms.Label attentionRowLabel;
        private System.Windows.Forms.Label attentionColumnLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}