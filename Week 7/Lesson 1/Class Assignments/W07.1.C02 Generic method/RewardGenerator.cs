using System.Collections;

public static class RewardGenerator
{
    private static Random random = new(0);

    public static Object GetRandomElement(IList list)
    {
        return list[random.Next(0, list.Count)] ?? new List<IList>();
    }
}