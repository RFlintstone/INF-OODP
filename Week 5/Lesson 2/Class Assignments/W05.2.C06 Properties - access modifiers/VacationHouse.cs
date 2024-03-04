public class VacationHouse(double squareMeters, int numberOfRooms) : House(squareMeters, numberOfRooms, true, true)
{
    public override void HomeImprovement()
    {
        base.HomeImprovement();
        NumberOfRooms++;
    }
}