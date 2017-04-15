using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Application
{
    public class DepthFirstSearch
    {
        public SearchObjects DoTheThing(SearchObjects obj)
        {
            if (obj.CurrNode.LeftNode != null && obj.MazeMatrix[obj.CurrNode.LeftNode.Row, obj.CurrNode.LeftNode.Column] == ' ')
            {
                obj.MazeMatrix[obj.CurrNode.LeftNode.Row, obj.CurrNode.LeftNode.Column] = '0';
            }
            if (obj.CurrNode.RightNode != null && obj.MazeMatrix[obj.CurrNode.RightNode.Row, obj.CurrNode.RightNode.Column] == ' ')
            {
                obj.MazeMatrix[obj.CurrNode.RightNode.Row, obj.CurrNode.RightNode.Column] = '0';
            }
            if (obj.CurrNode.UpNode != null && obj.MazeMatrix[obj.CurrNode.UpNode.Row, obj.CurrNode.UpNode.Column] == ' ')
            {
                obj.MazeMatrix[obj.CurrNode.UpNode.Row, obj.CurrNode.UpNode.Column] = '0';
            }
            if (obj.CurrNode.DownNode != null && obj.MazeMatrix[obj.CurrNode.DownNode.Row, obj.CurrNode.DownNode.Column] == ' ')
            {
                obj.MazeMatrix[obj.CurrNode.DownNode.Row, obj.CurrNode.DownNode.Column] = '0';
            }
            if (obj.MazeMatrix[obj.CurrNode.Row, obj.CurrNode.Column] == '0')
            {
                obj.MazeMatrix[obj.CurrNode.Row, obj.CurrNode.Column] = '1';
            }
            PrintOuts.PrintMatrix(obj.MazeMatrix);
            Console.WriteLine();

            if ((obj.CurrNode.LeftNode != null && obj.MazeMatrix[obj.CurrNode.LeftNode.Row, obj.CurrNode.LeftNode.Column] == 'F') || (obj.CurrNode.RightNode != null && obj.MazeMatrix[obj.CurrNode.RightNode.Row, obj.CurrNode.RightNode.Column] == 'F') || (obj.CurrNode.UpNode != null && obj.MazeMatrix[obj.CurrNode.UpNode.Row, obj.CurrNode.UpNode.Column] == 'F') || (obj.CurrNode.DownNode != null && obj.MazeMatrix[obj.CurrNode.DownNode.Row, obj.CurrNode.DownNode.Column] == 'F'))
            {
               return obj;
            }
            else if (obj.CurrNode.LeftNode != null && obj.MazeMatrix[obj.CurrNode.LeftNode.Row, obj.CurrNode.LeftNode.Column] == '0')
            {
                var next = new SearchObjects() {CurrNode = obj.CurrNode.LeftNode, MazeMatrix = obj.MazeMatrix};
                obj = DoTheThing(next);
            }
            else if (obj.CurrNode.RightNode != null && obj.MazeMatrix[obj.CurrNode.RightNode.Row, obj.CurrNode.RightNode.Column] == '0')
            {
                var next = new SearchObjects() { CurrNode = obj.CurrNode.RightNode, MazeMatrix = obj.MazeMatrix };
                obj = DoTheThing(next);
            }
            else if (obj.CurrNode.UpNode != null && obj.MazeMatrix[obj.CurrNode.UpNode.Row, obj.CurrNode.UpNode.Column] == '0')
            {
                var next = new SearchObjects() { CurrNode = obj.CurrNode.UpNode, MazeMatrix = obj.MazeMatrix };
                obj = DoTheThing(next);
            }
            else if (obj.CurrNode.DownNode != null &&
                     obj.MazeMatrix[obj.CurrNode.DownNode.Row, obj.CurrNode.DownNode.Column] == '0')
            {
                var next = new SearchObjects() {CurrNode = obj.CurrNode.DownNode, MazeMatrix = obj.MazeMatrix};
                obj = DoTheThing(next);
            }
            else
            {
                obj.MazeMatrix[obj.CurrNode.Row, obj.CurrNode.Column] = '2';
                PrintOuts.PrintMatrix(obj.MazeMatrix);
                Console.WriteLine();
            }
            
            return obj;
        }
    }
}
