namespace aMAZEing
{
    partial class MainForm
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
            this.generateMazeBtn = new System.Windows.Forms.Button();
            this.heightNum = new System.Windows.Forms.NumericUpDown();
            this.widthNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).BeginInit();
            this.SuspendLayout();
            // 
            // generateMazeBtn
            // 
            this.generateMazeBtn.Location = new System.Drawing.Point(26, 1006);
            this.generateMazeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.generateMazeBtn.Name = "generateMazeBtn";
            this.generateMazeBtn.Size = new System.Drawing.Size(322, 146);
            this.generateMazeBtn.TabIndex = 1;
            this.generateMazeBtn.Text = "Generate a Maze";
            this.generateMazeBtn.UseVisualStyleBackColor = true;
            this.generateMazeBtn.Click += new System.EventHandler(this.generateMazeBtn_Click);
            // 
            // heightNum
            // 
            this.heightNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightNum.Location = new System.Drawing.Point(472, 1029);
            this.heightNum.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.heightNum.Name = "heightNum";
            this.heightNum.Size = new System.Drawing.Size(120, 44);
            this.heightNum.TabIndex = 2;
            // 
            // widthNum
            // 
            this.widthNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthNum.Location = new System.Drawing.Point(472, 1089);
            this.widthNum.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.widthNum.Name = "widthNum";
            this.widthNum.Size = new System.Drawing.Size(120, 44);
            this.widthNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 1031);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 1091);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Width:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(2740, 1175);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthNum);
            this.Controls.Add(this.heightNum);
            this.Controls.Add(this.generateMazeBtn);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(2734, 1246);
            this.Name = "MainForm";
            this.Text = "aMAZEing";
            ((System.ComponentModel.ISupportInitialize)(this.heightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generateMazeBtn;
        private System.Windows.Forms.NumericUpDown heightNum;
        private System.Windows.Forms.NumericUpDown widthNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

