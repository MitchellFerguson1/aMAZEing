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
        Maze maze;
        int numClicks = 1;
        bool choiceEnabled = false;

        public MainForm()
        {
            InitializeComponent();
            this.CreateGraphics().Clear(Color.LightGray);
            SetStFn.Enabled = false;
        }

        private void generateMazeBtn_Click(object sender, EventArgs e)
        {
            int height = (int)heightNum.Value;
            int width = (int)widthNum.Value;
            maze = new Maze(this.CreateGraphics(), width, height);
            maze.createGrid();
            maze.generateMaze();
            SetStFn.Enabled = true;
        }

        private void SetStFn_Click(object sender, EventArgs e)
        {
            generateMazeBtn.Enabled = false;
            SetStFn.Enabled = false;
            choiceEnabled = true;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if(choiceEnabled)
            {
                if (numClicks % 2 != 0)
                {
                    maze.setStart(e.X, e.Y);
                    numClicks++;
                } else if(numClicks % 2 == 0)
                {
                    maze.setFinish(e.X, e.Y);
                    numClicks++;
                    choiceEnabled = false;
                    generateMazeBtn.Enabled = true;
                }
            }
        }
    }
}
