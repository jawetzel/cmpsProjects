using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextSparseMatrix
{
    public class RowHeadNode : HeadNode
    {
        public RowHeadNode()
        {
            this.NextInRow = this;
        }

        public override ValueNode GetFirst()
        {
            return (ValueNode)this.NextInColumn;
        }

        public override HeadNode GetNext()
        {
            return (HeadNode)this.NextInRow;
        }

        public override ValueNode Get(int Position)
        {
            ValueNode CurrentNode = this.GetFirst();
            do
            {
                if (CurrentNode == null)
                {
                    return null;
                }
                if (CurrentNode.Column == Position)
                {
                    return CurrentNode;
                }
                if (CurrentNode.NextInColumn == this.GetFirst())
                {
                    return null;
                }
                CurrentNode = (ValueNode)CurrentNode.NextInColumn;
            }
            while (CurrentNode.Column <= Position);
            return null;
        }

        
        public override void Insert(ValueNode InsertNode)
        {
            if (this.GetFirst() == null)
            {
                this.NextInColumn = InsertNode;
                return;
            }
            ValueNode Current = this.GetFirst();
            ValueNode Past = this.GetFirst();
            
            do
            {
                if (Current.Column == InsertNode.Column)
                {
                    Current.Value = InsertNode.Value;
                    return;
                }
                if (Current.NextInColumn == this.GetFirst())
                {
                    Current.NextInColumn = InsertNode;
                    InsertNode.NextInColumn = this.GetFirst();
                }
                Past = Current;
                Current = (ValueNode)Current.NextInColumn;

            }
            while (Current.Column <= InsertNode.Column);
            InsertNode.NextInColumn = Current;
            Past.NextInColumn = InsertNode;
            return;
        }
    }
}
