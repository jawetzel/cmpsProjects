namespace HomeWork3.Queue
{
    class Queue : List.List, IQueue
    {
        public bool IsEmpty()
        {
            return Length == 0;
        }

        public object Peek()
        {
            if (Length > 0)
            {
                return HeadNode.DataObject;
            }
            throw new EmptyQueueException();
        }

        public object DeQueue()
        {
            if (Length > 0)
            {
                return RemoveFront();
            }
            throw new EmptyQueueException();
        }

        public void EnQueue(object insertObject)
        {
            InsertBack(insertObject);
        }
    }
}
