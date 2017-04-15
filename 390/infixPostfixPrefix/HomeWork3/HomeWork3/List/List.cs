namespace HomeWork3.List
{
    public class List : IList
    {
        public Node HeadNode { get; set; }
        public Node TailNode { get; set; }
        public int Length { get; set; }

        public List()
        {
            Length = 0;
        }
        public object Get(int index)
        {
            var counter = 1;
            var currentNode = HeadNode;
            if (index > Length)
            {
                return null;
            }
            if (index < 1)
            {
                return null;
            }
            while (counter < index)
            {
                counter++;
                currentNode = currentNode.NextNode;
            }
            return currentNode.DataObject;
        }

        public int GetSize()
        {
            return Length;
        }

        public void InsertFront(object insertObject)
        {
            Length++;
            var insertNode = new Node() {DataObject = insertObject, NextNode = HeadNode};
            if (HeadNode == null || TailNode == null)
            {
                TailNode = insertNode;
            }
            HeadNode = insertNode;
        }

        public void InsertBack(object insertObject)
        {
            Length++;
            var insertNode = new Node() { DataObject = insertObject };
            if (HeadNode == null || TailNode == null)
            {
                HeadNode = insertNode;
                TailNode = insertNode;
            }
            else
            {
                TailNode.NextNode = insertNode;
                TailNode = insertNode;
            }
        }

        public object RemoveFront()
        {
            Length--;
            var returnObject = HeadNode.DataObject;
            if (HeadNode.NextNode == null)
            {
                HeadNode = null;
                TailNode = null;
                return returnObject;
            }
            HeadNode = HeadNode.NextNode;        
            return returnObject;
        }

        public object RemoveBack()
        {
            Length--;
            var returnObject = TailNode.DataObject;
            if (HeadNode == TailNode)
            {
                HeadNode = null;
                TailNode = null;
                return returnObject;
            }
            var currentNode = HeadNode;
            while (currentNode.NextNode != TailNode)
            {
                currentNode = currentNode.NextNode;
            }
            TailNode = currentNode;
            return returnObject;
        }
    }
}
