using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextSparseMatrix
{
    public class ValueNode : Node
    {
        public int Row { set; get; }
        public int Column { set; get; }
        public int Value { set; get; }

        public ValueNode()
        {
            this.NextInColumn = this;
            this.NextInRow = this;
        }
    }
}
