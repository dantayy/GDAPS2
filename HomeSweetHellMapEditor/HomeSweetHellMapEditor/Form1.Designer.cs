namespace HomeSweetHellMapEditor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.numOfRowsLabel = new System.Windows.Forms.Label();
            this.numOfColumnsLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.mapGenerationGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mapGenerationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(55, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.listBox1.Location = new System.Drawing.Point(29, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(41, 95);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.listBox2.Location = new System.Drawing.Point(102, 42);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(41, 95);
            this.listBox2.Sorted = true;
            this.listBox2.TabIndex = 2;
            // 
            // numOfRowsLabel
            // 
            this.numOfRowsLabel.AutoSize = true;
            this.numOfRowsLabel.Location = new System.Drawing.Point(26, 23);
            this.numOfRowsLabel.Name = "numOfRowsLabel";
            this.numOfRowsLabel.Size = new System.Drawing.Size(56, 13);
            this.numOfRowsLabel.TabIndex = 3;
            this.numOfRowsLabel.Text = "# of Rows";
            // 
            // numOfColumnsLabel
            // 
            this.numOfColumnsLabel.AutoSize = true;
            this.numOfColumnsLabel.Location = new System.Drawing.Point(99, 23);
            this.numOfColumnsLabel.Name = "numOfColumnsLabel";
            this.numOfColumnsLabel.Size = new System.Drawing.Size(69, 13);
            this.numOfColumnsLabel.TabIndex = 4;
            this.numOfColumnsLabel.Text = "# of Columns";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(29, 143);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(114, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Generate Map";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // mapGenerationGroupBox
            // 
            this.mapGenerationGroupBox.Controls.Add(this.submitButton);
            this.mapGenerationGroupBox.Controls.Add(this.numOfColumnsLabel);
            this.mapGenerationGroupBox.Controls.Add(this.numOfRowsLabel);
            this.mapGenerationGroupBox.Controls.Add(this.listBox2);
            this.mapGenerationGroupBox.Controls.Add(this.listBox1);
            this.mapGenerationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.mapGenerationGroupBox.Name = "mapGenerationGroupBox";
            this.mapGenerationGroupBox.Size = new System.Drawing.Size(183, 187);
            this.mapGenerationGroupBox.TabIndex = 6;
            this.mapGenerationGroupBox.TabStop = false;
            this.mapGenerationGroupBox.Text = "Map Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 503);
            this.Controls.Add(this.mapGenerationGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mapGenerationGroupBox.ResumeLayout(false);
            this.mapGenerationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label numOfRowsLabel;
        private System.Windows.Forms.Label numOfColumnsLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox mapGenerationGroupBox;
    }
}

