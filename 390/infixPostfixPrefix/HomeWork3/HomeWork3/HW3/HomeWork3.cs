using System;
using System.Security.Cryptography.X509Certificates;
using HomeWork3.HW3.Conversion;

namespace HomeWork3.HW3
{
    public class HomeWork3
    {
        static void Main(string[] args)
        {
            const string infix = @"C:\Google Drive\School\2016 - 3 Fall\Cmps 390\CurrentHw3\Files\InFixList.txt";
            const string operand = @"C:\Google Drive\School\2016 - 3 Fall\Cmps 390\CurrentHw3\Files\OperandList.txt";

            var homeWork = new HomeWork3();

            homeWork.Run(infix, operand);
        }

        public void Run(string inFixFile, string operandFile)
        {
            var operandList = FileReader.ReadFile(operandFile);
            var inFixlist = FileReader.ReadFile(inFixFile);
            foreach (var a in operandList)
            {
                var operand = a.Split(' ');
                Console.WriteLine("Operator " + operand[0] + " is " + operand[1]);
            }
            Console.WriteLine("");
            foreach (var inFixString in inFixlist)
            {
                Console.WriteLine("Infix Expression is: " + inFixString);

                var infix = new InFix(inFixString);
                var postfix = infix.ToPostFix();
                Console.WriteLine("PostFix Expression is: " + postfix.Expression);

                var result = postfix.Evaluate(operandList);
                Console.WriteLine("Result Of Expression is: " + result);
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
