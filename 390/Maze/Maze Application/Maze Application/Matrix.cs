using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Application
{
    public class Matrix
    {
        public static List<Node> GetEdgeSet(char[,] matrix)
        {
            var returnList = new List<Node>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == ' ' || matrix[i, j] == 'E' || matrix[i, j] == 'F')
                    {
                        var node = new Node();
                        if (i + 1 < matrix.GetLength(0) && (matrix[i + 1, j] == ' ' || matrix[i + 1, j] == 'E' || matrix[i + 1, j] == 'F'))
                        {
                            node.DownNode = new Node() {Column = j, Row = i + 1, Value = matrix[i + 1, j]};
                        }
                        if (i - 1 >= 0 && (matrix[i - 1, j] == ' ' || matrix[i - 1, j] == 'E' || matrix[i - 1, j] == 'F'))
                        {
                            node.UpNode = (new Node() { Column = j, Row = i - 1, Value = matrix[i - 1, j] });
                        }
                        if (j + 1 < matrix.GetLength(1) && (matrix[i, j + 1] == ' ' || matrix[i, j + 1] == 'E' || matrix[i, j + 1] == 'F'))
                        {
                            node.RightNode = (new Node() { Column = j + 1, Row = i, Value = matrix[i, j + 1] });
                        }
                        if (j - 1 >= 0 && (matrix[i, j - 1] == ' ' || matrix[i, j - 1] == 'E' || matrix[i, j - 1] == 'F'))
                        {
                            node.LeftNode = (new Node() { Column = j - 1, Row = i, Value = matrix[i, j - 1] });
                        }

                        node.Column = j;
                        node.Row = i;
                        node.Value = matrix[i, j];

                        returnList.Add(node);
                    }
                }
            }
            return returnList;
        }

        public static Node FindHeadNode(List<Node> edgeSet)
        {
            foreach (var node in edgeSet)
            {
                if (node.Value == 'E')
                {
                    return node;
                }
            }
            return null;
        }

        public static void AttachNodesToRoot(Node matrix, List<Node> edgeSet)
        {
            Node currentNode = matrix;
            foreach (var node in edgeSet)
            {
                if (currentNode.UpNode != null)
                {
                    if (node.Column == matrix.UpNode.Column && node.Row == matrix.UpNode.Row)
                    {
                        currentNode.UpNode = node;
                    }
                }
                if (currentNode.DownNode != null)
                {
                    if (node.Column == matrix.DownNode.Column && node.Row == matrix.DownNode.Row)
                    {
                        currentNode.DownNode = node;
                    }
                }
                if (currentNode.LeftNode != null)
                {
                    if (node.Column == matrix.LeftNode.Column && node.Row == matrix.LeftNode.Row)
                    {
                        currentNode.LeftNode = node;
                    }
                }
                if (currentNode.RightNode != null)
                {
                    if (node.Column == matrix.RightNode.Column && node.Row == matrix.RightNode.Row)
                    {
                        currentNode.RightNode = node;
                    }
                }

                foreach (var adjNode in edgeSet)
                {
                    if (adjNode.Column == node.UpNode?.Column && adjNode.Row == node.UpNode.Row)
                    {
                        node.UpNode = adjNode;
                    }
                    if (adjNode.Column == node.DownNode?.Column && adjNode.Row == node.DownNode.Row)
                    {
                        node.DownNode = adjNode;
                    }
                    if (adjNode.Column == node.LeftNode?.Column && adjNode.Row == node.LeftNode.Row)
                    {
                        node.LeftNode = adjNode;
                    }
                    if (adjNode.Column == node.RightNode?.Column && adjNode.Row == node.RightNode.Row)
                    {
                        node.RightNode = adjNode;
                    }
                }
            }
        }
    }
}
