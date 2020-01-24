using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Diagnostics;

namespace aMAZEing
{
    class Maze
    {
        private Graphics g;
        private int X;
        private int Y;
        private const int CELL_SIZE = 20;
        private Pen gridPen = new Pen(Color.Black);
        private Brush cellBrush = Brushes.MediumPurple;
        private Pen cellWallPen = new Pen(Color.Blue);
        private const int TOP_PADDING = 20;
        private const int SIDE_PADDING = 20;
        private Node[,] cells;
        private Node wall = new Node();


        public Maze(Graphics g, int X, int Y)
        {
            this.g = g;
            this.X = X;
            this.Y = Y;
            g.Clear(Color.LightGray);
            cells = new Node[X, Y]; //Start is always top right, end is always bottom Left
        }

        public void createGrid()
        {
            for (int row = 0; row < X; row++)
            {
                for (int column = 0; column < Y; column++)
                {
                    drawRectangle(gridPen, row, column);
                }
            }
        }

        public void generateMaze()
        {
            int currentX = 0;
            int currentY = 0;
            bool hasEmptyCells = true;
            bool beginning = true;
            Node currentNode = new Node(); //This should be overriddent later
            Node newNode = new Node();
            while (hasEmptyCells)
            {
                //Choose random starting position (Right now is 0,0. Later will be user chosen)
                if (beginning)
                {
                    cells[currentX, currentY] = new Node();
                    if (currentX == 0 && currentY == 0)
                        cells[currentX, currentY].setIsStart(true);
                    currentNode = cells[currentX, currentY];
                }
                if (currentX == 0 && currentY == 0)
                    fillRectangle(cellBrush, currentX, currentY, currentNode.getDirections());

                Thread.Sleep(5);

                //See if cell has any empty neighbors, if not find a parent that has empty neighbors
                if (!currentNode.hasEmptyNeighbor())
                {
                    currentNode = findEmptyNeighbor(currentNode);
                    if (currentNode.getIsStart())
                        break;

                    currentX = -1;
                    currentY = -1;

                    //Find index of the item
                    if (currentX == -1 && currentY == -1)
                    {
                        for (int x = 0; x <= X - 1; x++)
                        {
                            for (int y = 0; y <= Y - 1; y++)
                            {
                                if (cells[x, y] != null && cells[x, y].Equals(currentNode))
                                {
                                    currentX = x;
                                    currentY = y;
                                    break;
                                }
                            }
                            if (currentX != -1)
                                break;
                        }
                    }
                }

                //Randomly choose a wall that isn't occupied
                int newX = currentX;
                int newY = currentY;
                int direction = -1;
                while (newX == currentX && newY == currentY)
                {
                    direction = new Random().Next(1, 5);
                    switch (direction) //1 = left, 2 = right, 3 = up, 4 = down
                    {
                        case 1:
                            newX--;
                            if (newX < 0 || cells[newX, currentY] != null)
                                newX++;
                            break;
                        case 2:
                            newX++;
                            if (newX >= X || cells[newX, currentY] != null)
                                newX--;
                            break;
                        case 3:
                            newY--;
                            if (newY < 0 || cells[currentX, newY] != null)
                                newY++;
                            break;
                        case 4:
                            newY++;
                            if (newY >= Y || cells[currentX, newY] != null)
                                newY--;
                            break;
                    }
                }

                currentNode.addDirection(direction);

                //Create a new current cell
                cells[newX, newY] = new Node();
                newNode = cells[newX, newY];

                switch (direction)
                {
                    case 1:
                        newNode.addDirection(2);
                        break;

                    case 2:
                        newNode.addDirection(1);
                        break;

                    case 3:
                        newNode.addDirection(4);
                        break;

                    case 4:
                        newNode.addDirection(3);
                        break;
                }

                //Put here to help debugging
                if (newX != 0 || newY != 0)
                {
                    fillRectangle(cellBrush, currentX, currentY, currentNode.getDirections());
                    fillRectangle(cellBrush, newX, newY, newNode.getDirections());
                }

                newNode.setParent(currentNode);
                currentX = newX;
                currentY = newY;
                currentNode = newNode;

                //Set neighbors
                if (currentNode.getParent() == null)
                {
                    currentNode.setUp(wall);
                    currentNode.setLeft(wall);
                }
                else
                {
                    if (currentX > 0 && cells[currentX - 1, currentY] != null)
                    {
                        currentNode.setLeft(cells[currentX - 1, currentY]);
                        cells[currentX - 1, currentY].setRight(currentNode);
                    }
                    else if (currentX == 0)
                        currentNode.setLeft(wall);

                    if (currentX < X - 1 && cells[currentX + 1, currentY] != null)
                    {
                        currentNode.setRight(cells[currentX + 1, currentY]);
                        cells[currentX + 1, currentY].setLeft(currentNode);
                    }
                    else if (currentX + 1 == X)
                        currentNode.setRight(wall);

                    if (currentY > 0 && cells[currentX, currentY - 1] != null)
                    {
                        currentNode.setUp(cells[currentX, currentY - 1]);
                        cells[currentX, currentY - 1].setDown(currentNode);
                    }
                    else if (currentY == 0)
                        currentNode.setUp(wall);

                    if (currentY < Y - 1 && cells[currentX, currentY + 1] != null)
                    {
                        currentNode.setDown(cells[currentX, currentY + 1]);
                        cells[currentX, currentY + 1].setUp(currentNode);
                    }
                    else if (currentY + 1 == Y)
                        currentNode.setDown(wall);
                }

                beginning = false;
            }
        }

        public void setStart(int x, int y)
        {
            int nodeX = converter(x);
            int nodeY = converter(y);

            Node startNode = cells[nodeX, nodeY];
            startNode.setIsStart(true);

            fillRectangle(Brushes.Green, nodeX, nodeY, startNode.getDirections());
        }

        public void setFinish(int x, int y)
        {
            int nodeX = converter(x);
            int nodeY = converter(y);

            Node finishNode = cells[nodeX, nodeY];
            finishNode.setIsEnd(true);

            fillRectangle(Brushes.Red, nodeX, nodeY, finishNode.getDirections());
        }

        private int converter(int num)
        {
            return ((num - SIDE_PADDING) - (num % CELL_SIZE)) / CELL_SIZE;
        }

        private void drawRectangle(Pen pen, int row, int column)
        {
            g.DrawRectangle(pen, new Rectangle(row * CELL_SIZE + TOP_PADDING, column * CELL_SIZE + SIDE_PADDING, CELL_SIZE, CELL_SIZE));
        }

        private void fillRectangle(Brush brush, int row, int column, List<int> directions)
        {
            g.FillRectangle(brush, new Rectangle(row * CELL_SIZE + TOP_PADDING, column * CELL_SIZE + SIDE_PADDING, CELL_SIZE, CELL_SIZE));

            //Draw the walls
            //1 = left, 2 = right, 3 = up, 4 = down
            for (int path = 1; path <= 4; path++)
            {
                if (!directions.Contains(path))
                {
                    switch (path)
                    {
                        case 1:
                            g.DrawLine(Pens.Black,
                                row * CELL_SIZE + TOP_PADDING,
                                column * CELL_SIZE + SIDE_PADDING,
                                row * CELL_SIZE + TOP_PADDING,
                                column * CELL_SIZE + SIDE_PADDING + CELL_SIZE);
                            break;

                        case 2:
                            g.DrawLine(Pens.Black,
                                row * CELL_SIZE + TOP_PADDING + CELL_SIZE,
                                column * CELL_SIZE + SIDE_PADDING,
                                row * CELL_SIZE + TOP_PADDING + CELL_SIZE,
                                column * CELL_SIZE + SIDE_PADDING);
                            break;

                        case 3:
                            g.DrawLine(Pens.Black,
                                row * CELL_SIZE + TOP_PADDING,
                                column * CELL_SIZE + SIDE_PADDING,
                                row * CELL_SIZE + TOP_PADDING + CELL_SIZE,
                                column * CELL_SIZE + SIDE_PADDING);
                            break;

                        case 4:
                            g.DrawLine(Pens.Black,
                                row * CELL_SIZE + TOP_PADDING,
                                column * CELL_SIZE + SIDE_PADDING + CELL_SIZE,
                                row * CELL_SIZE + TOP_PADDING,
                                column * CELL_SIZE + SIDE_PADDING + CELL_SIZE);
                            break;
                    }
                }
            }
        }

        private Node findEmptyNeighbor(Node currentNode)
        {
            if (currentNode.hasEmptyNeighbor()) //Return node if it has empty neighbors
                return currentNode;
            else if (currentNode.hasEmptyNeighbor() == false && currentNode.getIsStart()) //If the node is the start node return the node
                return currentNode;
            else //Otherwise go to the parent
                return findEmptyNeighbor(currentNode.getParent());
        }
    }
}
