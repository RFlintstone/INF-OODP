class Present
{
    private object _contents;
    public bool IsWrapped { get; private set; }
    public string Hint { get; }

    public Present(object contents)
    {
        _contents = contents;
        IsWrapped = true;

        Hint = _contents switch
        {
            Lego lego => "It is a Lego set!",
            BoardGame boardGame => $"It is a board game by {boardGame.Publisher}!     ",
            Toy toy => "It is a toy!",
            Movie movie => "It is a movie!",
            Present present => "It is a surprise!",
            _ => ":("
        };

    }

    public void Unwrap() => IsWrapped = false;

    public object? GetContents()
    {
        if (IsWrapped)
            return null;
        return _contents;
    }
}