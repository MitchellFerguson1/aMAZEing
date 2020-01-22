using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    class Node
    {
        private Node parentNode;
        private Node up, down, left, right;
        private bool isStart, isEnd;
        private List<int> directions = new List<int>();

        public Node()
        {

        }

#region Getter methods
        public Node getParent() { return parentNode; }
        public Node getUp() { return up; }
        public Node getDown() { return down; }
        public Node getLeft() { return left; }
        public Node getRight() { return right; }
        public bool getIsStart() { return isStart; }
        public bool getIsEnd() { return isEnd; }
        public List<int> getDirections() {return directions; }
#endregion

#region Setter methods
        public void setParent(Node parentNode) { this.parentNode = parentNode; }
        public void setUp(Node up) { this.up = up; }
        public void setDown(Node down) { this.down = down; }
        public void setLeft(Node left) { this.left = left; }
        public void setRight(Node right) { this.right = right; }
        public void addDirection(int direction) {directions.Add(direction); }
        //These two methods aren't used but are implemented for later use
        public void setIsEnd(bool isEnd) { this.isEnd = isEnd; }
        public void setIsStart(bool isStart) { this.isStart = isStart; }
#endregion

        public bool hasEmptyNeighbor()
        {
            if (up == null || down == null || left == null || right == null)
                return true;
            return false;
        }
    }
}
