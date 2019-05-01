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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 611);
            this.Controls.Add(this.generateMazeBtn);
            this.Name = "MainForm";
            this.Text = "aMAZEing";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button generateMazeBtn;
    }
}

