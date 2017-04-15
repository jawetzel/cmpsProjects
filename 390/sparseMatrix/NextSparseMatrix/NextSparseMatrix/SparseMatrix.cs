using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextSparseMatrix
{
    public class SparseMatrix : Node
    {
        RowHeadNode StartRowHeadNode = new RowHeadNode();
        ColumnHeadNode StartColumnHeadNode = new ColumnHeadNode();
        int FixedNumColumns;
        int FixedNumRows;

        public SparseMatrix()
        {
            FixedNumColumns = 0;
            FixedNumRows = 0;
        }

        public SparseMatrix(int Rows, int Columns)
        {
            FixedNumColumns = Columns;
            FixedNumRows = Rows;
        }

        public RowHeadNode GetRow(int Position)
        {
            RowHeadNode CurrentHeadNode = StartRowHeadNode;
            if (Position == 1)
            {
                return StartRowHeadNode;
            }

            int i = 1;

            do
            {
                if (CurrentHeadNode.NextInRow == StartRowHeadNode)
                {
                    do
                    {
                        RowHeadNode NewRowHeadNode = new RowHeadNode();
                        NewRowHeadNode.NextInRow = StartRowHeadNode;
                        CurrentHeadNode.NextInRow = NewRowHeadNode;
                        CurrentHeadNode = NewRowHeadNode;
                        i++;
                    }
                    while (i < Position);
                    return CurrentHeadNode;
                }
                CurrentHeadNode = (RowHeadNode)CurrentHeadNode.NextInRow;
                i++;
            }
            while (i < Position);
            return CurrentHeadNode;

        }

        public ColumnHeadNode GetColumn(int Position)
        {
            ColumnHeadNode CurrentHeadNode = StartColumnHeadNode;
            if (Position == 1)
            {
                return StartColumnHeadNode;
            }

            int i = 1;

            do
            {
                if (CurrentHeadNode.NextInColumn == StartColumnHeadNode)
                {
                    do
                    {
                        ColumnHeadNode NewCHeadNode = new ColumnHeadNode();
                        NewCHeadNode.NextInColumn = StartColumnHeadNode;
                        CurrentHeadNode.NextInColumn = NewCHeadNode;
                        CurrentHeadNode = NewCHeadNode;
                        i++;
                    }
                    while (i < Position);
                    return CurrentHeadNode;
                }
                CurrentHeadNode = (ColumnHeadNode)CurrentHeadNode.NextInColumn;
                i++;
            }
            while (i < Position);
            return CurrentHeadNode;
        }

        public void Insert(int Column, int Row, int Value)
        {
            ValueNode NewValueNode = new ValueNode();
            NewValueNode.Column = Column;
            NewValueNode.Row = Row;
            NewValueNode.Value = Value;

            this.GetRow(Row).Insert(NewValueNode);
            this.GetColumn(Column).Insert(NewValueNode);
        }

        public int GetValue(int Row, int Column)
        {
            return this.GetRow(Row).Get(Column).Value;
        }

        public void Print()
        {
            ColumnHeadNode CurrentCHeadNode = StartColumnHeadNode;
            RowHeadNode CurrentRowHeadNode = StartRowHeadNode;
            int CurrentRows;
            int CurrentColumns;

            if (FixedNumColumns > 0 || FixedNumRows > 0)
            {
                CurrentRows = FixedNumRows;
                CurrentColumns = FixedNumColumns;
            }
            else
            {
                CurrentRows = 1;
                CurrentColumns = 1;

                while (CurrentRowHeadNode.NextInRow != StartRowHeadNode)
                {
                    CurrentRows++;
                    CurrentRowHeadNode = (RowHeadNode)CurrentRowHeadNode.NextInRow;
                }

                while (CurrentCHeadNode.NextInColumn != StartColumnHeadNode)
                {
                    CurrentColumns++;
                    CurrentCHeadNode = (ColumnHeadNode)CurrentCHeadNode.NextInColumn;
                }
            }

            ValueNode CurrentValueNode;

            for (int i = 1; i  <= CurrentRows; i++)
            {
                CurrentRowHeadNode = this.GetRow(i);
                for (int j = 1; j <= CurrentColumns; j++)
                {
                    CurrentValueNode = CurrentRowHeadNode.Get(j);
                    if (CurrentValueNode == null)
                    {
                        Console.Write("0  ");
                    }
                    else
                    {
                        Console.Write(CurrentValueNode.Value + "  ");
                    }
                }
                Console.WriteLine("");
            }                      
        }

        public SparseMatrix Transpose()
        {            
            ColumnHeadNode CurrentCHeadNode = StartColumnHeadNode;
            RowHeadNode CurrentRowHeadNode = StartRowHeadNode;
            int Rows = 1;
            int Columns = 1;

            while (CurrentRowHeadNode.NextInRow != StartRowHeadNode)
            {
                Rows++;
                CurrentRowHeadNode = (RowHeadNode)CurrentRowHeadNode.NextInRow;
            }

            while (CurrentCHeadNode.NextInColumn != StartColumnHeadNode)
            {
                Columns++;
                CurrentCHeadNode = (ColumnHeadNode)CurrentCHeadNode.NextInColumn;
            }

            SparseMatrix NewMatrix = new SparseMatrix(Columns, Rows);
            ValueNode CurrentValueNode;
            for (int i = 1; i <= Rows; i++)
            {
                CurrentRowHeadNode = this.GetRow(i);
                for (int j = 1; j <= Columns; j++)
                {
                    CurrentValueNode = CurrentRowHeadNode.Get(j);
                    if (CurrentValueNode != null)
                    {
                        NewMatrix.Insert(CurrentValueNode.Row, CurrentValueNode.Column, CurrentValueNode.Value);
                    }
                }
            }
            return NewMatrix;
        }

        public SparseMatrix Product(SparseMatrix SeccondMatrix)
        {
            RowHeadNode MatrixARow = this.StartRowHeadNode;
            ColumnHeadNode MatrixBColumn = SeccondMatrix.StartColumnHeadNode;
            SparseMatrix ReturnMatrix = new SparseMatrix(this.FixedNumRows, SeccondMatrix.FixedNumColumns);

            do
            {
                ValueNode NodeA = MatrixARow.GetFirst();
                ValueNode NodeB = MatrixBColumn.GetFirst();
                do
                {
                    if (NodeA == null || NodeB == null)
                    {
                        break;
                    }
                    if (NodeA.Column > NodeB.Row)
                    {
                        NodeB = (ValueNode)NodeB.NextInRow;
                    }
                    if (NodeA.Column < NodeB.Row)
                    {
                        NodeA = (ValueNode)NodeA.NextInColumn;
                    }
                    if (NodeA.Column == NodeB.Row)
                    {
                        ReturnMatrix.Insert(NodeA.Column, NodeA.Row, (NodeA.Value * NodeB.Value));
                        NodeB = (ValueNode)NodeB.NextInRow;
                        NodeA = (ValueNode)NodeA.NextInColumn;
                    }
                }
                while (NodeA != MatrixARow.GetFirst() && NodeB != MatrixBColumn.GetFirst());

                MatrixARow = (RowHeadNode)MatrixARow.GetNext();
                MatrixBColumn = (ColumnHeadNode)MatrixBColumn.GetNext();
            }
            while (MatrixARow != this.StartRowHeadNode && MatrixBColumn != SeccondMatrix.StartColumnHeadNode);
            return ReturnMatrix;
        }
    }
}
