using System.Collections.Generic;

class Ventilator
{
    public int Speed;
    public List<Button> Buttons;

    public Ventilator() => Buttons = new List<Button>()
        { new Button(), new Button(), new Button(), new Button() };

    public void PressButton(int number)
    {
        if (number < 0 || number >= Buttons.Count) return;
        
        for (int i = 0; i < Buttons.Count; i++)
        {
            Buttons[number].IsPressed = number == i || number == 1;
            if (Buttons[i].IsPressed)
            {
                Speed = i;
            }
        }
    }

    public string Blow() => Speed switch
    {
        <= 0 => "Off",
        1 => "~~~",
        2 => "^^^",
        >= 3 => "===",
    };
}