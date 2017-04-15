using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Application
{
    public class Node
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public char Value { get; set; }

        public Node UpNode { get; set; }
        public Node DownNode { get; set; }
        public Node RightNode { get; set; }
        public Node LeftNode { get; set; }

        public Node NextNode { get; set; }

    }
}
