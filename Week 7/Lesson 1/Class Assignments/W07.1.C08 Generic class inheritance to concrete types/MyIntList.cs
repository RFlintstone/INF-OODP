public class MyIntList : MyGenericList<int>
{
    public MyIntList(List<int> elems) : base(elems) { }
    public override int Combine()
    {
        int sum = 0;
        foreach (var elem in Elems)
        {
            sum += elem;
        }
        return sum;
    }
}