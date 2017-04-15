using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Application
{
    class FileReader
    {
        public static char[,] ReadFile(string fileName)
        {           
            var read = new StreamReader(fileName);

            var lineCount = File.ReadLines(fileName).Count();
            var currentString = read.ReadLine();
            var lineLength = currentString.Length;
            var mazeMatrix = new char[lineCount, lineLength];

            for (int i = 0; i < lineCount; i++)
            {
                for (int j = 0; j < lineLength; j++)
                {
                    mazeMatrix[i, j] = currentString[j];
                }
                currentString = read.ReadLine();
            }

            return mazeMatrix;
        }
    }
}
