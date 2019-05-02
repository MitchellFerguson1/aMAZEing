using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace aMAZEing
{
    class Maze
    {
        private Graphics g;
        private int rows;
        private int columns;
        private const int CELL_SIZE = 20;
        private Pen gridPen = new Pen(Color.Black);
        private Brush cellBrush = Brushes.MediumPurple;
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
            bool beginning = true;
            Node currentNode = new Node(); //This should be overriddent later
            Node newNode = new Node();
            while (hasEmptyCells)
            {
                //Choose random starting position (Right now is 0,0. Later will be user chosen)
                if (beginning)
                {
                    cells[currentRow, currentColumn] = new Node();
                    if (currentRow == 0 && currentColumn == 0)
                        cells[currentRow, currentColumn].setIsStart(true);
                    currentNode = cells[currentRow, currentColumn];
                }
                fillRectangle(cellBrush, currentRow, currentColumn);
                Thread.Sleep(1000);

                //See if cell has any empty neighbors, if not find a parent that has empty neighbors
                if(!currentNode.hasEmptyNeighbor())
                {
                    newNode = findEmptyNeighbor(currentNode);
                    if (newNode.getIsStart())
                        break;
                }

                //Randomly choose a wall that isn't occupied
                int newRow = currentRow;
                int newColumn = currentColumn;
                int direction = -1;
                while (newRow == currentRow && newColumn == currentColumn)
                {
                    direction = new Random().Next(1, 5);
                    switch (direction) //1 = up, 2 = down, 3 = left, 4 = right
                    {
                        case 1:
                            newRow--;
                            if (newRow < 0 || cells[newRow, currentColumn] != null)
                                newRow++;
                            break;
                        case 2:
                            newRow++;
                            if (newRow >= rows || cells[newRow, currentColumn] != null)
                                newRow--;
                            break;
                        case 3:
                            newColumn--;
                            if (newColumn < 0 || cells[currentRow, newColumn] != null)
                                newColumn++;
                            break;
                        case 4:
                            newColumn++;
                            if (newColumn >= columns || cells[currentRow, newColumn] != null)
                                newColumn--;
                            break;
                    }
                }

                //Create a new current cell
                cells[newRow, newColumn] = new Node();
                newNode = cells[newRow, newColumn];
                newNode.setParent(currentNode);
                switch (direction) //1 = up, 2 = down, 3 = left, 4 = right
                {
                    case 1:
                        currentNode.setUp(newNode);
                        newNode.setDown(currentNode);
                        break;
                    case 2:
                        currentNode.setDown(newNode);
                        newNode.setUp(currentNode);
                        break;
                    case 3:
                        currentNode.setLeft(newNode);
                        newNode.setRight(currentNode);
                        break;
                    case 4:
                        currentNode.setRight(newNode);
                        newNode.setLeft(currentNode);
                        break;
                }
                currentRow = newRow;
                currentColumn = newColumn;
                currentNode = newNode;
            }
        }

        private void drawRectangle(Pen pen, int row, int column)
        {
            g.DrawRectangle(pen, new Rectangle(row * CELL_SIZE + TOP_PADDING, column * CELL_SIZE + SIDE_PADDING, CELL_SIZE, CELL_SIZE));
        }

        private void fillRectangle(Brush brush, int row, int column)
        {
            g.FillRectangle(brush, new Rectangle(row * CELL_SIZE + TOP_PADDING, column * CELL_SIZE + SIDE_PADDING, CELL_SIZE, CELL_SIZE));

        }

        private Node findEmptyNeighbor(Node currentNode)
        {
            if (currentNode.hasEmptyNeighbor()) //Return node if it has empty neighbors
                return currentNode;
            else if (currentNode.hasEmptyNeighbor() == false && currentNode.getIsStart()) //If the node is the start node return the node
                return currentNode;
            else //Otherwise go to the parent
                findEmptyNeighbor(currentNode.getParent());
            return null; //This should never be called
        }
    }
}
