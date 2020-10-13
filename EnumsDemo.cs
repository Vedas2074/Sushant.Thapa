using System;

public enum Days
{
    Sunday,Monday,Tuesday,Wednesday,Thursday,Friday
}
class EnumDemo
{
    static void Main15()
    {
        Days d = (Days)5;
        Console.WriteLine(d);
        
    }
}