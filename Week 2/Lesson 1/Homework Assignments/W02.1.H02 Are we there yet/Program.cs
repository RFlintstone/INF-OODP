﻿// The teacher / course creator created the full code as this assignment is meant to be ignored by the students as of 09/02/2024
public class Location
{
    public int ID;
    public string Name;
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;

    public Location(int id, string name)
    {
        ID = id;
        Name = name;
    }

    public string Compass()
    {
        //Settings > Debug > Console: Collapse Identical Lines
        string s = "From here you can go:\n";
        if (LocationToNorth != null)
        {
            s += "    N\n    |\n";
        }
        if (LocationToWest != null)
        {
            s += "W---|";
        }
        else
        {
            s += "    |";
        }
        if (LocationToEast != null)
        {
            s += "---E";
        }
        s += "\n";
        if (LocationToSouth != null)
        {
            s += "    |\n    S\n";
        }
        return s;
    }

    public string NextLocationOptions()
    {
        string s = "";
        if (LocationToNorth != null)
            s += "N";
        if (LocationToEast != null)
            s += "E";
        if (LocationToSouth != null)
            s += "S";
        if (LocationToWest != null)
            s += "W";
        return s;
    }

    public Location GetLocationAt(string location)
    {
        if (location == "N") return LocationToNorth;
        if (location == "E") return LocationToEast;
        if (location == "S") return LocationToSouth;
        if (location == "W") return LocationToWest;
        return null;
    }
}