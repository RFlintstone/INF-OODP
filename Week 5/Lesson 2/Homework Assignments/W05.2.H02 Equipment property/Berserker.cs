class Berserker : Fighter
{
    Berserker(string name, Weapon mainWeapon, Weapon secondaryWeapon) : base(name, mainWeapon)
    {
        SecondaryWeapon = secondaryWeapon;
    }
}