// See Button.cs for the code for Codegrade.

using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Press how many times?");
        var pressHowManyTimes = Convert.ToInt32(Console.ReadLine());
        Button button = new();
        for (int i = 0; i < pressHowManyTimes; i++)
            button.Press();

        Console.WriteLine(button.Info());
    }
}