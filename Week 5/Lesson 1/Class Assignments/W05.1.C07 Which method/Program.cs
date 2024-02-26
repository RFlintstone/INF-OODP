using System;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        //Create an instance of SevenElevenVariant with a seed of 0 here.
        //Then call its only public method.
        SevenElevenVariant game = new(0);
        game.PlayGame();
        
        // Or if you somehow want to use reflection...I don't know why you would, especially in production code.
        // And yes, Codegrade's 'is_method_called' test does not pass with reflection.
        // SevenElevenVariant game2 = new(0);
        // Type type = game2.GetType();
        // MethodInfo[] methods = type.GetMethods();
        // foreach (var method in methods)
        // {
        //     if (method.Name is "PlayGame")
        //     {
        //         method.Invoke(game2, null);
        //     }
        // }
    }
}