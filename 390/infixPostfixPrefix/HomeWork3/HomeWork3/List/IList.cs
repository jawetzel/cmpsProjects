namespace HomeWork3.List
{
    public interface IList
    {
        object Get(int index);
        int GetSize();
        void InsertFront(object insertObject);
        void InsertBack(object insertObject);
        object RemoveFront();
        object RemoveBack();
    }
}
