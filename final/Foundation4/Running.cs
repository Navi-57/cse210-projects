using System;
using System.Collections.Generic;

class Running : Activity
{
    private double distance; // in miles

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed()
    {
        return (distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / distance;
    }
}