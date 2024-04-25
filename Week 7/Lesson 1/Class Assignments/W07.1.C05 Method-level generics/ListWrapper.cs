public class ListWrapper<T>
{
    private List<T> _myList = new();

    public void Add(T item) => _myList.Add(item);

    public T Get(int index) => _myList[index];

    public int Count => _myList.Count;

    public int HighestCount<U>(ListWrapper<U> otherList)
    {
        return _myList.Count;
    }
}