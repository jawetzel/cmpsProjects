using System.Collections.Generic;
using System.IO;

namespace HomeWork3.HW3
{
    public static class FileReader
    {
        public static List<string> ReadFile(string fileName)
        {
            var read = new StreamReader(fileName);

            var returnList = new List<string>();
            string currentLine;    
            while ((currentLine = read.ReadLine()) != null)
            {
                returnList.Add(currentLine);
            }
            return returnList;
        }
    }
}
