using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace aMAZEing
{
    class Maze
    {
        private Graphics g;
        private int rows;
        private int columns;
        private const int CELL_SIZE = 20;
        private Pen gridPen = new Pen(Color.Black);
        private Pen cellPen = new Pen(Color.MediumPurple);
        private Pen cellWallPen = new Pen(Color.Blue);
        private const int TOP_PADDING = 25;
        private const int SIDE_PADDING = 25;
        private Node[,] cells;

        
        public Maze(Graphics g, int rows, int columns)
        {
            this.g = g;
            this.rows = rows;
            this.columns = columns;
            g.Clear(Color.LightGray);
            cells = new Node[rows, columns]; //Start is always top right, end is always bottom Left
        }

        public void createGrid()
        {
            for(int row = 0; row < rows; row++)
            {
                for(int column = 0; column < columns; column++)
                {
                    drawRectangle(gridPen, row, column);
                }
            }
        }

        public void generateMaze()
        {
            int currentRow = 0;
            int currentColumn = 0;
            bool hasEmptyCells = true;
            while (hasEmptyCells)
            {
                //Choose random starting position (Right now is 0,0. Later will be user chosen)
                cells[currentRow, currentColumn] = new Node();
                if(currentRow == 0 && currentColumn == 0)
                cells[currentRow, currentColumn].setIsStart(true);
                drawRectangle(cellPen, currentRow, currentColumn);
                
                //Randomly choose a wall

            }
        }

        private void drawRectangle(Pen pen, int row, int column)
        {
            g.DrawRectangle(pen, new Rectangle(row * CELL_SIZE + TOP_PADDING, column * CELL_SIZE + SIDE_PADDING, CELL_SIZE, CELL_SIZE));

        }
    }
}
