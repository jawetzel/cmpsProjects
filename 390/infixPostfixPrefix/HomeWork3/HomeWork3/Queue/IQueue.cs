namespace HomeWork3.Queue
{
    interface IQueue
    {
        int GetSize();
        bool IsEmpty();
        object Peek();
        object DeQueue();
        void EnQueue(object insertObject);
    }
}
