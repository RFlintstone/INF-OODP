class Cruiser : Motorcycle
{
    protected int SeatHeight;

    public Cruiser(string make, string model, int year, int seatHeight) : base(make, model, year)
    {
        SeatHeight = seatHeight;
    }
    
    public override string Ride() => $"Riding a {Make} {Model} from {Year} with a seat height of {SeatHeight} cm";
}