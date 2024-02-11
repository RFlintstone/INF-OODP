public class DNA
{
    public string Seq;

    public DNA(string sequence)
    {
        Seq = sequence;
    }

    public DNA Replicate1() => new DNA(Seq);

    public DNA Replicate2() => this;

    public void Mutate(string newSeq) => Seq = newSeq;
}