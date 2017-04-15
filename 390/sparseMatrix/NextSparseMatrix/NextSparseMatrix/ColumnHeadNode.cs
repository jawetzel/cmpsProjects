using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextSparseMatrix
{
    public class ColumnHeadNode : HeadNode
    {
        public ColumnHeadNode()
        {
            this.NextInColumn = this;
        }

        public override ValueNode GetFirst()
        {
            return (ValueNode)this.NextInRow;
        }

        public override HeadNode GetNext()
        {
            return (HeadNode)this.NextInColumn;
        }

        public override ValueNode Get(int Position)
        {
            ValueNode CurrentNode = this.GetFirst();
            do
            {
                if (CurrentNode.Row == Position)
                {
                    return CurrentNode;
                }
                if (CurrentNode.NextInRow == this.GetFirst())
                {
                    return null;
                }
                CurrentNode = (ValueNode)CurrentNode.NextInRow;
            }
            while (CurrentNode.Row <= Position);
            return null;
        }


        public override void Insert(ValueNode InsertNode)
        {
            if (this.GetFirst() == null)
            {
                this.NextInRow = InsertNode;
                return;
            }
            ValueNode Current = this.GetFirst();
            ValueNode Past = this.GetFirst();

            do
            {
                if (Current.Row == InsertNode.Row)
                {
                    Current.Value = InsertNode.Value;
                    return;
                }
                if (Current.NextInRow == this.GetFirst())
                {
                    Current.NextInRow = InsertNode;
                    InsertNode.NextInRow = this.GetFirst();
                }
                Past = Current;
                Current = (ValueNode)Current.NextInRow;

            }
            while (Current.Row <= InsertNode.Row);
            InsertNode.NextInRow = Current;
            Past.NextInRow = InsertNode;
            return;
        }
    }
}
