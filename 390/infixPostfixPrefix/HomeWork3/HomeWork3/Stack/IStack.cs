namespace HomeWork3.Stack
{
    interface IStack
    {
        int GetSize();
        bool IsEmpty();
        object Peek();
        object Pop();
        void Push(object insertObject);
    }
}
