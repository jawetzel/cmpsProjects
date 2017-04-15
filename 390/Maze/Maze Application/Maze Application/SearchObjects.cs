using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Application
{
    public class SearchObjects
    {
        public char[,] MazeMatrix { get; set; }
        public Node CurrNode { get; set; }
    }
}
