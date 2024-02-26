class HarleyDavidson : Cruiser
{
    public HarleyDavidson(string model, int year) : base("Harley Davidson", model, year, 25)
    {
        SeatHeight = 68;
    }
    
    public override string Ride() => $"Riding a {Make} {Model} from {Year} with a seat height of {SeatHeight} cm and with pride.";
}