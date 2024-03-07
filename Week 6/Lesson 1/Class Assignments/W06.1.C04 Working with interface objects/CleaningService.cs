public static class CleaningService
{
    public static void Clean(ICleanable item)
    {
        item.Clean();
    }

    public static void Clean(List<ICleanable> items)
    {
        foreach (ICleanable item in items)
        {
            item.Clean();
        }
    }
}