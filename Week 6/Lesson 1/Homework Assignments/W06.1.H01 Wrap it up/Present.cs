class Present
{
    private object _contents;
    public bool IsWrapped { get; private set; }

    public string Hint
    {
        get {
            if (!IsWrapped)
                return "it is already unwrapped.";
            return _contents switch
            {
                Lego lego => "It is a Lego set!",
                BoardGame boardGame => $"It is a board game by {boardGame.Publisher}!     ",
                Toy toy => "It is a toy!",
                Movie movie => "It is a movie!",
                _ => "It is a surprise!"
            };
        } 
    }

    public Present(object contents)
    {
        _contents = contents;
        IsWrapped = true;
    }

    public void Unwrap() => IsWrapped = false;

    public object? GetContents()
    {
        if (IsWrapped)
            return null;
        return _contents;
    }
}