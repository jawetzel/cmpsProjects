using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            const string mazefile = @"C:\Google Drive\School\2016 - 3 Fall\Cmps 390\Hw4\Files\MazeFile.txt"; //file reading from
            var mazeMatrix = FileReader.ReadFile(mazefile);  //write file into 2d array
            Console.WriteLine("Maze Matrix");
            PrintOuts.PrintMatrix(mazeMatrix);
            Console.WriteLine();

            var edgeSet = Matrix.GetEdgeSet(mazeMatrix);   //obtain edge set from 2d array

            var matrixGraph = Matrix.FindHeadNode(edgeSet); //find root node for graph's Root
            Matrix.AttachNodesToRoot(matrixGraph, edgeSet);  //fill in graph with starting point

            var dfs = new DepthFirstSearch();

            Console.WriteLine("Depth First Search");
            var DFSResult = dfs.DoTheThing(new SearchObjects() {CurrNode = matrixGraph, MazeMatrix = mazeMatrix }).MazeMatrix;
            Console.WriteLine();


            Console.WriteLine("Depth First Search Result");
            PrintOuts.PrintMatrix(DFSResult);
            Console.WriteLine();

            //Console.WriteLine("Breadth First Search");
            //Console.WriteLine();

            var bfs = new BreathFirstSearch();
            var BFSResult = bfs.BFS(mazeMatrix, matrixGraph);
            //PrintOuts.PrintMatrix(BFSResult);
            //Console.WriteLine("Breadth First Search Result");
            //Console.WriteLine();


            Console.ReadLine();

        }


    }
}
