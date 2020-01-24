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
            this.SetStFn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).BeginInit();
            this.SuspendLayout();
            // 
            // generateMazeBtn
            // 
            this.generateMazeBtn.Location = new System.Drawing.Point(13, 523);
            this.generateMazeBtn.Name = "generateMazeBtn";
            this.generateMazeBtn.Size = new System.Drawing.Size(161, 76);
            this.generateMazeBtn.TabIndex = 1;
            this.generateMazeBtn.Text = "Generate a Maze";
            this.generateMazeBtn.UseVisualStyleBackColor = true;
            this.generateMazeBtn.Click += new System.EventHandler(this.generateMazeBtn_Click);
            // 
            // heightNum
            // 
            this.heightNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightNum.Location = new System.Drawing.Point(236, 535);
            this.heightNum.Margin = new System.Windows.Forms.Padding(2);
            this.heightNum.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.heightNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.heightNum.Name = "heightNum";
            this.heightNum.Size = new System.Drawing.Size(60, 26);
            this.heightNum.TabIndex = 2;
            this.heightNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // widthNum
            // 
            this.widthNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthNum.Location = new System.Drawing.Point(236, 566);
            this.widthNum.Margin = new System.Windows.Forms.Padding(2);
            this.widthNum.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.widthNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.widthNum.Name = "widthNum";
            this.widthNum.Size = new System.Drawing.Size(60, 26);
            this.widthNum.TabIndex = 3;
            this.widthNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 536);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 567);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Width:";
            // 
            // SetStFn
            // 
            this.SetStFn.Location = new System.Drawing.Point(301, 523);
            this.SetStFn.Name = "SetStFn";
            this.SetStFn.Size = new System.Drawing.Size(161, 76);
            this.SetStFn.TabIndex = 6;
            this.SetStFn.Text = "Set start and finish";
            this.SetStFn.UseVisualStyleBackColor = true;
            this.SetStFn.Click += new System.EventHandler(this.SetStFn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1370, 599);
            this.Controls.Add(this.SetStFn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthNum);
            this.Controls.Add(this.heightNum);
            this.Controls.Add(this.generateMazeBtn);
            this.MinimumSize = new System.Drawing.Size(967, 579);
            this.Name = "MainForm";
            this.Text = "aMAZEing";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
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
        private System.Windows.Forms.Button SetStFn;
    }
}

