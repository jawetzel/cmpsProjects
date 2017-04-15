namespace HomeWork3.Stack
{
    public class Stack : List.List, IStack
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
            throw new EmptyStackException();
        }

        public object Pop()
        {
            if (Length > 0)
            {
                return RemoveFront();
            }
            throw new EmptyStackException();
        }

        public void Push(object insertObject)
        {
            InsertFront(insertObject);
        }
    }
}
