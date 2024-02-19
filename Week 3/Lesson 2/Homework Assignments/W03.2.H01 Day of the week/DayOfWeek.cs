public class DayOfWeek
{
    private int currentDay;

    public DayOfWeek(int day)
    {
        if (day < 0) this.currentDay = (day % 7 + 7) % 7;
        else this.currentDay = day % 7;
    }

    public static string IndexToDay(int index)
    {
        index = (index + 7) % 7;
        var day = index switch
        {
            0 => "Monday",
            1 => "Tuesday",
            2 => "Wednesday",
            3 => "Thursday",
            4 => "Friday",
            5 => "Saturday",
            6 => "Sunday",
            _ => "Invalid index"
        };
        return day;
    }

    public bool IsWeekend()
    {
        return this.currentDay == 5 || this.currentDay == 6;
    }

    public string CurrentDay()
    {
        return IndexToDay(this.currentDay);
    }

    public string NextDay()
    {
        this.currentDay = (this.currentDay + 1) % 7;
        return CurrentDay();
    }
}