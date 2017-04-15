using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextSparseMatrix
{
    abstract public class HeadNode : Node
    {
        abstract public HeadNode GetNext();
        abstract public ValueNode GetFirst();
        abstract public ValueNode Get(int Position);
        abstract public void Insert(ValueNode InsertNode);
    }
}
