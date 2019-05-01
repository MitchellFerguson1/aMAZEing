using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aMAZEing
{
    public partial class MainForm : Form
    {
        private const int MAZE_FACTOR = 1;
        private const int UPPER_BUFFER = 20;
        private const int LOWER_BUFFER = 150;
        private const int SIDE_BUFFER = 20;
        private const int RIGHT_BUFFER = SIDE_BUFFER * 2;
        private int[,] mazeLayout;

        public MainForm()
        {
            InitializeComponent();
        }

        private void generateMazeBtn_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black);
            //The width and height count is off by 2. Not sure why
            int cellsWidth = ((this.Width - RIGHT_BUFFER) / MAZE_FACTOR) + 2;
            int cellsHeight = ((this.Height - LOWER_BUFFER) / MAZE_FACTOR) + 2;
            mazeLayout = new int[cellsHeight, cellsWidth];

            for(int widthLine = 1; widthLine < cellsHeight; widthLine++)
            {
                g.DrawLine(p, SIDE_BUFFER, widthLine * UPPER_BUFFER, this.Width - RIGHT_BUFFER + 4, widthLine * UPPER_BUFFER); //Not sure why but the width is off by 4, this corrects
            }
            for(int heightLine = 1; heightLine < cellsWidth; heightLine++)
            {
                g.DrawLine(p, (heightLine * SIDE_BUFFER), UPPER_BUFFER, (heightLine * SIDE_BUFFER), this.Height - LOWER_BUFFER);
            }
        }
    }
}
