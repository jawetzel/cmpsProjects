using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextSparseMatrix
{
    public abstract class Node
    {
        public Node NextInColumn { set; get; }
        public Node NextInRow { set; get; }
    }
}
