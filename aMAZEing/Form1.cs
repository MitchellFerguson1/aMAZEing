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

        public MainForm()
        {
            InitializeComponent();
            this.CreateGraphics().Clear(Color.LightGray);
        }

        private void generateMazeBtn_Click(object sender, EventArgs e)
        {
            int height = (int)heightNum.Value;
            int width = (int)widthNum.Value;
            maze = new Maze(this.CreateGraphics(), width, height);
            maze.createGrid();
        }
    }
}
