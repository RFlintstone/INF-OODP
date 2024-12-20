﻿using System;
using static System.Console;

internal class Program
{
    public static void Main(string[] args)
    {
        const int spdOfLightInMperS = 299792458;
        const double daysInYear = 365.242199;
        const string planetName = "LP 890-9b";
        const double distanceFromEarthInLightYear = 100;
        
        WriteLine("The planet " + planetName + " is " + distanceFromEarthInLightYear + " lightyears away from Earth.");
        WriteLine("In meters this is " + distanceFromEarthInLightYear * spdOfLightInMperS * daysInYear * 24 * 60 * 60);
    }
}