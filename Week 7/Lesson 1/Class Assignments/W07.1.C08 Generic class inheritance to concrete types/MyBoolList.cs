public class MyBoolList : MyGenericList<bool>
{
    public MyBoolList(List<bool> elems) : base(elems) { }
    public override bool Combine()
    {
        bool result = true;
        foreach (var elem in Elems)
        {
            result &= elem;
        }
        return result;
    }
}