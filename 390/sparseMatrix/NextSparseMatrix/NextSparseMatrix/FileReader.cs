using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextSparseMatrix
{
    public class FileReader
    {
        public SparseMatrix ReadFile(string AddressOfTableToRead)
        {
            
            string ReadLine;
            int RowCounter = 1;
            StreamReader ReadFile = new StreamReader(AddressOfTableToRead);
            int Row = int.Parse(ReadFile.ReadLine());
            int Column = int.Parse(ReadFile.ReadLine());
            SparseMatrix NewMatrix = new SparseMatrix(Row, Column);
            while ((ReadLine = ReadFile.ReadLine()) != null) 
            {
                string[] Entries = ReadLine.Split(' ');
                foreach (string Entry in Entries)
                {
                    string[] ValueString = Entry.Split(',');
                    int ColumnValue = int.Parse(ValueString[0]);
                    int ValueValue = int.Parse(ValueString[1]);
                    NewMatrix.Insert(ColumnValue, RowCounter, ValueValue);
                }
                RowCounter++;
            }
            ReadFile.Close();
            return NewMatrix;
        }
    }
}
