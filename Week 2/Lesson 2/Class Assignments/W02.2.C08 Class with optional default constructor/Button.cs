using System;

public class Button
{
    bool IsPressed;
    int TimesPressed;
    
    public Button()
    {
        IsPressed = false;
        TimesPressed = 0;
    }
    
    public void Press()
    {
        IsPressed = !IsPressed;
        TimesPressed++;
    }
    
    public string Info()
    {
        return $"Button is {(IsPressed ? "pressed" : "not pressed")}.\nPressed {TimesPressed} times.";
    }
}