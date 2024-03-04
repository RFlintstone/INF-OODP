class ProgressPopup : Popup
{
    private int _progress = 0;
    private string _progressBar = "";

    public ProgressPopup(string message) : base(message) => Display();

    public void IncreaseProgress(int percentage)
    {
        if (_progress + percentage > 100)
            _progress = 100;
        else
            _progress += percentage;
        Display();
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"{_progress}%\t{new String('|', _progress/10)}");
    }
}