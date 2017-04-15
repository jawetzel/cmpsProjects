using System;
using System.Collections.Generic;

namespace Maze_Application
{
    internal class BreathFirstSearch
    {
        public BreathFirstSearch()
        {
        }

        public char[,] BFS(char[,] mazeMatrix, Node startNode)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(startNode);
            mazeMatrix = BreadthFirstSearch(mazeMatrix, queue);
            //PrintOuts.PrintMatrix(mazeMatrix);
            return mazeMatrix;
        }

        public char[,] BreadthFirstSearch(char[,] mazeMatrix, Queue<Node> queue)
        {
            if (queue.Count == 0)
            {
                return mazeMatrix;
            }

            Node currNode = queue.Dequeue();
            mazeMatrix[currNode.Column, currNode.Row] = '1';

            if (currNode.DownNode != null && mazeMatrix[currNode.Row + 1, currNode.Column] == ' ')
            {
                queue.Enqueue(currNode.DownNode);
                mazeMatrix[currNode.Row + 1, currNode.Column] = '0';
            }
            if (currNode.UpNode != null && mazeMatrix[currNode.Row - 1, currNode.Column] == ' ')
            {
                queue.Enqueue(currNode.UpNode);
                mazeMatrix[currNode.Row - 1, currNode.Column] = '0';
            }
            if (currNode.LeftNode != null && mazeMatrix[currNode.Row, currNode.Column - 1] == ' ')
            {
                queue.Enqueue(currNode.LeftNode);
                mazeMatrix[currNode.Row, currNode.Column - 1] = '0';
            }
            if (currNode.RightNode != null && mazeMatrix[currNode.Row, currNode.Column + 1] == ' ')
            {
                queue.Enqueue(currNode.RightNode);
                mazeMatrix[currNode.Row, currNode.Column + 1] = '0';
            }

            //PrintOuts.PrintMatrix(mazeMatrix);
            return BreadthFirstSearch(mazeMatrix, queue);
        }
    }
}