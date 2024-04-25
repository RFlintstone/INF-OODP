public class Triple<T1, T2, T3>
{
    public T1 Fst { get; }
    public T2 Snd { get; }
    public T3 Trd { get; }

    public Triple(T1 fst, T2 snd, T3 trd)
    {
        Fst = fst;
        Snd = snd;
        Trd = trd;
    }
}