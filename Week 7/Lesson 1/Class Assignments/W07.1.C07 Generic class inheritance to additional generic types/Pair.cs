public class Pair<T1, T2>
{
    public T1 Fst { get; }
    public T2 Snd { get; }

    public Pair(T1 fst, T2 snd)
    {
        Fst = fst;
        Snd = snd;
    }
}