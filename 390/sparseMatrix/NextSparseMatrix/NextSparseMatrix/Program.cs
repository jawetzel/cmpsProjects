using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NextSparseMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            FileReader fileReader = new FileReader();
            SparseMatrix MatrixA = fileReader.ReadFile(@"C:\GoogleDrive\School\Old School Stuff\2016 - 3 Fall\Cmps 390\Hw2\MatrixA.txt");

            SparseMatrix MatrixB = fileReader.ReadFile(@"C:\GoogleDrive\School\Old School Stuff\2016 - 3 Fall\Cmps 390\Hw2\MatrixB.txt");

            Console.WriteLine("\nMatrix A is \n \n");
            MatrixA.Print();

            Console.WriteLine("\nMatrix B is \n \n");
            MatrixB.Print();

            SparseMatrix MatrixC = MatrixA.Transpose();
            Console.WriteLine("\nMatrix A Transposed is \n\n");
            MatrixC.Print();

            SparseMatrix MatrixD = MatrixB.Transpose();
            Console.WriteLine("\nMatrix B Transposed is \n\n");
            MatrixD.Print();

            SparseMatrix MatrixE = MatrixA.Product(MatrixB);
            Console.WriteLine("\nMatrix A Times Matrix B is \n\n");
            MatrixE.Print();

            SparseMatrix MatrixF = MatrixC.Product(MatrixD);
            Console.WriteLine("\nMatrix A Transposed Times Matrix B Transposed is \n\n");
            MatrixF.Print();

            Console.Read();
        }
    }
}
